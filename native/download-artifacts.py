import os
import requests
import zipfile
import io
import argparse

# === CONFIGURATION ===
REPO = 'EvergineTeam/ImGui.Net'  # GitHub repository path
WORKFLOW_FILENAMES = [
    'cimgui-cmake.yml',
    'cimguizmo-cmake.yml',
    'cimnodes-cmake.yml',
    'cimplot-cmake.yml'
]  # GitHub Actions workflow files
TARGET_DIR = './'  # Base directory to extract artifacts into

# Mapping from artifact substrings to folder names
ARCH_MAPPING = {
    'macos-latest-arm64': 'osx-arm64',
    'macos-latest-x86_64': 'osx-x64',
    'ubuntu-latest-arm64': 'linux-arm64',
    'ubuntu-latest-x86_64': 'linux-x64',
    'windows-latest-arm64': 'win-arm64',
    'windows-latest-x86_64': 'win-x64',
    'windows-latest-x86': 'win-x86'
}

def get_headers(token):
    return {
        'Authorization': f'token {token}',
        'Accept': 'application/vnd.github+json'
    }

def get_latest_successful_run(session, workflow_filename):
    url = f'https://api.github.com/repos/{REPO}/actions/workflows/{workflow_filename}/runs?status=success&per_page=1'
    print(f"Fetching workflow runs from: {url}")
    response = session.get(url)
    response.raise_for_status()
    runs = response.json().get('workflow_runs', [])
    if not runs:
        raise Exception(f"No successful workflow runs found for {workflow_filename}.")
    print(f"Found successful run ID: {runs[0]['id']} for workflow {workflow_filename}")
    return runs[0]['id']

def get_artifacts(session, run_id):
    url = f'https://api.github.com/repos/{REPO}/actions/runs/{run_id}/artifacts'
    print(f"Fetching artifacts from: {url}")
    response = session.get(url)
    response.raise_for_status()
    artifacts = response.json().get('artifacts', [])
    print(f"Found {len(artifacts)} artifacts.")
    return artifacts

def download_and_extract_artifact(session, artifact):
    download_url = artifact['archive_download_url']
    name = artifact['name']

    print(f"Downloading artifact: {name} from {download_url}")
    response = session.get(download_url)
    response.raise_for_status()

    with zipfile.ZipFile(io.BytesIO(response.content)) as z:
        print(f"Artifact {name} contains: {z.namelist()}")

        matched = False
        for key, folder in ARCH_MAPPING.items():
            if key in name:
                extract_path = os.path.join(TARGET_DIR, folder)
                print(f"Extracting to: {extract_path}")
                os.makedirs(extract_path, exist_ok=True)
                z.extractall(path=extract_path)
                print(f"Extraction completed for: {name}")
                matched = True
                break

        if not matched:
            print(f"No matching folder mapping found for artifact: {name}")

def main():
    parser = argparse.ArgumentParser(description='Download and extract GitHub Actions artifacts.')
    parser.add_argument('--token', required=True, help='GitHub Personal Access Token')
    args = parser.parse_args()

    session = requests.Session()
    session.headers.update(get_headers(args.token))

    for workflow_filename in WORKFLOW_FILENAMES:
        print(f"\nProcessing workflow: {workflow_filename}")
        run_id = get_latest_successful_run(session, workflow_filename)
        artifacts = get_artifacts(session, run_id)
        for artifact in artifacts:
            download_and_extract_artifact(session, artifact)

if __name__ == '__main__':
    main()
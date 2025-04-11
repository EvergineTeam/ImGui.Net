import os
import requests
import zipfile
import io
import argparse
import shutil

# === CONFIGURATION ===
REPO = 'EvergineTeam/ImGui.Net'  # GitHub repository path
LIB_NAMES = [ "Imgui", "Imguizmo", "Imnodes", "Implot" ]
# Mapping from artifact substrings to folder names
ARCH_MAPPING = {
    'macos-latest-arm64': 'osx-arm64',
    'macos-latest-x86_64': 'osx-x64',
    'ubuntu-latest-arm64': 'linux-arm64',
    'ubuntu-latest-x86_64': 'linux-x64',
    'windows-latest-arm64': 'win-arm64',
    'windows-latest-x86_64': 'win-x64',
    'windows-latest-x86': 'win-x86',
    'ubuntu-latest-wasm': 'browser-wasm'
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
        scripts_dir = os.path.dirname(os.path.abspath(__file__))
        tmp_dir = os.path.join(scripts_dir, "tmp")

        for key, folder in ARCH_MAPPING.items():
            if key in name:
                extract_path = os.path.join(tmp_dir, folder)
                print(f"Extracting to: {extract_path}")
                os.makedirs(extract_path, exist_ok=True)
                z.extractall(path=extract_path)
                print(f"Extraction completed for: {name}")
                matched = True
                return f"{folder}/{z.namelist()[0]}"

        print(f"No matching folder mapping found for artifact: {name}")

def main():
    parser = argparse.ArgumentParser(description='Download and extract GitHub Actions artifacts.')
    parser.add_argument('--token', required=True, help='GitHub Personal Access Token')
    args = parser.parse_args()

    session = requests.Session()
    session.headers.update(get_headers(args.token))
    scripts_dir = os.path.dirname(os.path.abspath(__file__))
    tmp_dir = os.path.join(scripts_dir, "tmp")

    for lib_name in LIB_NAMES:
        workflow_filename = f'c{lib_name.lower()}-cmake.yml'
        project_name = f'Evergine.Bindings.{lib_name}'
        project_dir = os.path.join(scripts_dir, "..", "Generator", project_name)
        project_runtimes_dir = os.path.join(project_dir, "runtimes")
        print(f"\nProcessing workflow: {workflow_filename}")
        run_id = get_latest_successful_run(session, workflow_filename)
        artifacts = get_artifacts(session, run_id)
        shutil.rmtree(project_runtimes_dir, ignore_errors=True)
        for artifact in artifacts:
            lib_path = download_and_extract_artifact(session, artifact)
            src_path = os.path.join(tmp_dir, lib_path)
            dst_path = os.path.join(project_runtimes_dir, lib_path.split("/")[0], "native")
            os.makedirs(dst_path, exist_ok=True)
            shutil.copy(src_path, dst_path)
            shutil.rmtree(tmp_dir, ignore_errors=True)


if __name__ == '__main__':
    main()
import os
import requests
import zipfile
import io
import argparse
import shutil

# === CONFIGURATION ===
REPO = 'EvergineTeam/ImGui.Net'  # GitHub repository path

def get_headers(token):
    return {
        'Authorization': f'token {token}',
        'Accept': 'application/vnd.github+json',
        'User-Agent': 'request'
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

    scripts_dir = os.path.dirname(os.path.abspath(__file__))
    runtimes_dir = os.path.join(scripts_dir, "..", "Generator", "Evergine.Bindings.Imgui", "runtimes")

    with zipfile.ZipFile(io.BytesIO(response.content)) as z:
        z.extractall(path=runtimes_dir)

def main():
    parser = argparse.ArgumentParser(description='Download and extract GitHub Actions artifacts.')
    parser.add_argument('--token', required=True, help='GitHub Personal Access Token')
    args = parser.parse_args()

    session = requests.Session()
    session.headers.update(get_headers(args.token))
    scripts_dir = os.path.dirname(os.path.abspath(__file__))

    workflow_filename = 'cimgui-cmake.yml'
    project_name = f'Evergine.Bindings.Imgui'
    project_dir = os.path.join(scripts_dir, "..", "Generator", project_name)
    project_runtimes_dir = os.path.join(project_dir, "runtimes")
    print(f"\nProcessing workflow: {workflow_filename}")
    run_id = get_latest_successful_run(session, workflow_filename)
    artifacts = get_artifacts(session, run_id)
    shutil.rmtree(project_runtimes_dir, ignore_errors=True)
    for artifact in artifacts:
        download_and_extract_artifact(session, artifact)


if __name__ == '__main__':
    main()
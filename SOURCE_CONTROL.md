# Source Control Scope

This repository is configured as a source-first Unity recovery repo.

Tracked source should include:

- Runtime recovery/gameplay code in `Assets/**/*.cs`
- Editor scene builders in `Assets/Editor/**/*.cs`
- Unity metadata for tracked source and generated recovery scenes
- Unity package and project settings under `Packages/` and `ProjectSettings/`
- Recreated playable scenes under `Assets/_IntroReal/`

Intentionally excluded from GitHub-oriented commits:

- `Library/`, `Temp/`, `Logs/`, `Builds/`, and other generated folders
- Raw extracted bundles under `Assets/StreamingAssets/`
- Extracted commercial audio, video, texture dumps, and dialogue database assets

Those excluded files can remain on this machine for local Unity playback, but should not be published unless you have the rights to distribute them.
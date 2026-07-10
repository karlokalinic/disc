using System;

[Serializable]
public class SceneProperties
{
	public string SceneName;

	public string SceneId;

	public string SaveGameId;

	public int VisualRadius;

	public bool IsOutside;

	public bool IsDreamScene;

	public bool HasCustomZoomLimits;

	public float CustomMinimumZoomLimit;

	public float CustomMaximumZoomLimit;

	public string DisplayName => null;
}

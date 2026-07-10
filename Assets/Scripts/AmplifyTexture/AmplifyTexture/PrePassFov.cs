using System;

namespace AmplifyTexture
{
	[Serializable]
	public struct PrePassFov
	{
		public float fov;

		public float fovScale;

		public bool autoFov;

		public PrePassFov(float value, float scale, bool auto)
		{
			fov = 0f;
			fovScale = 0f;
			autoFov = false;
		}
	}
}

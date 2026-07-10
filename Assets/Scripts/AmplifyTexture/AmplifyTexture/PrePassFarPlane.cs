using System;

namespace AmplifyTexture
{
	[Serializable]
	public struct PrePassFarPlane
	{
		public float farPlane;

		public float farPlaneScale;

		public bool autoFarPlane;

		public PrePassFarPlane(float value, float scale, bool auto)
		{
			farPlane = 0f;
			farPlaneScale = 0f;
			autoFarPlane = false;
		}
	}
}

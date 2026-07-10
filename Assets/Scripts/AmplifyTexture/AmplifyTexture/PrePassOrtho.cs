using System;

namespace AmplifyTexture
{
	[Serializable]
	public struct PrePassOrtho
	{
		public float size;

		public float sizeScale;

		public bool autoSize;

		public PrePassOrtho(float value, float scale, bool auto)
		{
			size = 0f;
			sizeScale = 0f;
			autoSize = false;
		}
	}
}

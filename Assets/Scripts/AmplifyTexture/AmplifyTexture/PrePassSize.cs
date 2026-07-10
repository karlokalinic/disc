using System;

namespace AmplifyTexture
{
	[Serializable]
	public struct PrePassSize
	{
		public int width;

		public int height;

		public bool autoSize;

		public PrePassSize(int w, int h, bool auto)
		{
			width = 0;
			height = 0;
			autoSize = false;
		}
	}
}

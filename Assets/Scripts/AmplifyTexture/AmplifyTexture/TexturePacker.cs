using System;
using UnityEngine;

namespace AmplifyTexture
{
	[Serializable]
	public sealed class TexturePacker
	{
		[SerializeField]
		private VirtualTexture m_asset;

		[SerializeField]
		private DynamicBinPacker m_rectPacker;

		public DynamicBinPacker RectPacker => null;

		public TexturePacker(VirtualTexture asset)
		{
		}

		public float ComputeUsedSpacePercentage()
		{
			return 0f;
		}

		public void Reset(VirtualTexture asset)
		{
		}

		public bool Pack(TextureCollection collection)
		{
			return false;
		}
	}
}

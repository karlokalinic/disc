using System;
using System.Collections.Generic;
using UnityEngine;

namespace AmplifyTexture
{
	[Serializable]
	public class VirtualTextureCollection : ScriptableObject
	{
		public string UniqueName;

		public List<VirtualTexture> VirtualTextures;

		private PageTablePacker m_pageTablePacker;

		public PageTablePacker PageTablePacker => null;

		public void Initialize()
		{
		}
	}
}

using System;
using System.Collections.Generic;
using UnityEngine;

namespace AmplifyTexture
{
	[Serializable]
	public sealed class TextureCombo : IComparable<TextureCombo>
	{
		[SerializeField]
		private TextureDesc[] m_layers;

		[SerializeField]
		private string m_signature;

		[SerializeField]
		private int m_signatureHash;

		[SerializeField]
		private int m_comboWidth;

		[SerializeField]
		private int m_comboHeight;

		[SerializeField]
		private int m_targetWidth;

		[SerializeField]
		private int m_targetHeight;

		[SerializeField]
		private bool m_tiled;

		public int m_area;

		public int m_largestSize;

		public Rectangle m_packedRect;

		public int m_tileTop;

		public int m_tileBottom;

		public int m_tileLeft;

		public int m_tileRight;

		public int m_numTilesWidth;

		public int m_numTilesHeight;

		public List<string> m_materials;

		public TextureDesc[] Layers => null;

		public string Signature => null;

		public int SignatureHash => 0;

		public int ComboWidth => 0;

		public int ComboHeight => 0;

		public int TargetWidth => 0;

		public int TargetHeight => 0;

		public bool Tiled => false;

		public UVGridType GridType => default(UVGridType);

		public int GridWidth => 0;

		public int GridHeight => 0;

		public int GridTileWidth => 0;

		public int GridTileHeight => 0;

		public static string MakeSignature(TextureDesc[] textures)
		{
			return null;
		}

		public TextureCombo(TextureDesc[] textures)
		{
		}

		public bool Initialize(VirtualTexture asset, TextureDesc.LoadImageHeader loadImageHeader, TextureDesc.GUIDToAssetPath guidToAssetPath, bool logRescaleWarning)
		{
			return false;
		}

		public void UpdateRects(VirtualTexture asset, Point location)
		{
		}

		public int CompareTo(TextureCombo other)
		{
			return 0;
		}
	}
}

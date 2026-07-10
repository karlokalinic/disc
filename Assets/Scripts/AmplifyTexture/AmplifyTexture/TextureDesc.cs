using System;
using UnityEngine;

namespace AmplifyTexture
{
	[Serializable]
	public sealed class TextureDesc
	{
		public delegate string GUIDToAssetPath(string guid);

		public delegate void LoadImageHeader(string path, out int width, out int height, out int bpp);

		public delegate object LoadImage(string path, int width, int height);

		public delegate void UnloadImage(object img);

		public delegate void GetImagePixel(object img, int x, int y, Color color);

		[SerializeField]
		private string m_guid;

		[SerializeField]
		private byte[] m_crc;

		[SerializeField]
		private TextureWrapMode m_wrapMode;

		[SerializeField]
		private bool m_linear;

		[SerializeField]
		private int m_width;

		[SerializeField]
		private int m_height;

		[SerializeField]
		private int m_bpp;

		[SerializeField]
		private UVGridType m_gridType;

		[SerializeField]
		private int m_gridWidth;

		[SerializeField]
		private int m_gridHeight;

		[SerializeField]
		private int m_gridTileWidth;

		[SerializeField]
		private int m_gridTileHeight;

		[SerializeField]
		private TextureMetaType m_metaType;

		[SerializeField]
		private TextureSource[] m_sources;

		public object m_image;

		public string GUID => null;

		public long CRC => 0L;

		public TextureWrapMode WrapMode => default(TextureWrapMode);

		public bool Linear => false;

		public int Width => 0;

		public int Height => 0;

		public int Bpp => 0;

		public bool Tiled => false;

		public UVGridType GridType => default(UVGridType);

		public int GridWidth => 0;

		public int GridHeight => 0;

		public int GridTileWidth => 0;

		public int GridTileHeight => 0;

		public TextureMetaType MetaType => default(TextureMetaType);

		public TextureSource[] Sources => null;

		public TextureDesc()
		{
		}

		public TextureDesc(string guid, long crc, TextureWrapMode wrapMode, bool linear, UVGridType gridType, int gridWidth, int gridHeight, TextureMetaType metaType, TextureSource[] sources)
		{
		}

		public bool Initialize(LoadImageHeader loadImageHeader, GUIDToAssetPath guidToAssetPath)
		{
			return false;
		}
	}
}

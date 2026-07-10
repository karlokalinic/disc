using System;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering;

namespace AmplifyTexture
{
	[Serializable]
	public sealed class PhysicalCache
	{
		public enum Size
		{
			_Adaptive = -2,
			_24MB_2048x1024 = -1,
			_48MB_2048x2048 = 0,
			_96MB_4096x2048 = 1,
			_192MB_4096x4096 = 2,
			_384MB_8192x4096 = 3,
			_768MB_8192x8192 = 4
		}

		internal static Tuple<Size, int, int>[] CacheSizeToDimensions;

		private RenderTexture m_diffuseCache;

		private RenderTexture m_normalCache;

		private RenderTexture m_specularCache;

		private Texture2DArray m_diffuse0CacheArray;

		private Texture2DArray m_normal0CacheArray;

		private Texture2DArray m_normal1CacheArray;

		private Texture2DArray m_specular0CacheArray;

		private Texture2DArray m_specular1CacheArray;

		private AmplifyTextureCamera m_runtime;

		private int m_pagesPerFrame;

		private int m_pageUploadIndex;

		private int m_numPagesPerWidth;

		private int m_numPagesPerHeight;

		private int m_numAvailablePages;

		private int m_numAllocatedPages;

		private int m_numPageTextures;

		private Texture2D[] m_pagesDiffuseTex;

		private Texture2D[] m_pagesNormalTex;

		private Texture2D[] m_pagesSpecularTex;

		private Texture2D[] m_pagesDiffuse0Tex;

		private Texture2D[] m_pagesNormal0Tex;

		private Texture2D[] m_pagesNormal1Tex;

		private Texture2D[] m_pagesSpecular0Tex;

		private Texture2D[] m_pagesSpecular1Tex;

		private Material m_blitMat;

		private Mesh m_quad;

		private MaterialPropertyBlock m_block;

		private MruDictionary<Page, PhysAddr> m_mru;

		public RenderTexture DiffuseCache => null;

		public RenderTexture NormalCache => null;

		public RenderTexture SpecularCache => null;

		public Texture2DArray Diffuse0CacheArray => null;

		public Texture2DArray Normal0CacheArray => null;

		public Texture2DArray Normal1CacheArray => null;

		public Texture2DArray Specular0CacheArray => null;

		public Texture2DArray Specular1CacheArray => null;

		public AmplifyTextureCamera Runtime => null;

		public int NumPagesPerWidth => 0;

		public int NumPagesPerHeight => 0;

		public int NumAvailablePages => 0;

		public int NumAllocatedPages => 0;

		internal RenderTexture CreateCacheRT(string name, int width, int height, RenderTextureReadWrite readWrite)
		{
			return null;
		}

		internal Texture2D CreateCacheTEX(string name, int width, int height, GraphicsFormat format)
		{
			return null;
		}

		internal Texture2DArray CreateCacheTEXArray(string name, int count, GraphicsFormat format)
		{
			return null;
		}

		internal Texture2D CreatePageTex(string name, GraphicsFormat format)
		{
			return null;
		}

		internal RenderTexture CreatePageRT(string name, GraphicsFormat format)
		{
			return null;
		}

		internal void DestroyRT(ref RenderTexture rtex)
		{
		}

		internal void DestroyTex<T>(ref T tex) where T : Texture
		{
		}

		internal static Mesh CreateQuadMesh()
		{
			return null;
		}

		internal static int GetNumAvailablePages(int cacheWidth, int cacheHeight, out int pagesPerWidth, out int pagesPerHeight)
		{
			pagesPerWidth = default(int);
			pagesPerHeight = default(int);
			return 0;
		}

		internal static int GetNumAvailablePages(int cacheWidth, int cacheHeight)
		{
			return 0;
		}

		internal PhysicalCache(AmplifyTextureCamera runtime)
		{
		}

		internal void Reset()
		{
		}

		internal void Destroy()
		{
		}

		internal bool LostData()
		{
			return false;
		}

		internal bool Touch(Page page)
		{
			return false;
		}

		internal void ProcessRequests(Page[] requests, int requestCount, int lowestMipCount, bool forceSync)
		{
		}

		private void SafeAllocateCache()
		{
		}

		private void SafeDestroyCache()
		{
		}

		private void SafeAllocatePages()
		{
		}

		private void SafeDestroyPages()
		{
		}

		internal void CheckResizePages()
		{
		}

		internal void UploadAndCopyPageToCache(CommandBuffer command, Texture2D page, byte[] pageBytes, Texture texture, int x, int y, PhysAddr address)
		{
		}

		internal void PageUploadImmediate(CommandBuffer command, int x, int y, PageRequest pageReq, PhysAddr address)
		{
		}

		internal void SubmitPage(CommandBuffer command, PageRequest pageReq)
		{
		}

		internal int Update(int maxUploadCount)
		{
			return 0;
		}

		internal void DebugRender(int targetSize)
		{
		}
	}
}

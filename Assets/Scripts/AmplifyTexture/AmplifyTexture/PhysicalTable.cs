using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

namespace AmplifyTexture
{
	[Serializable]
	public sealed class PhysicalTable
	{
		public struct AssetTable
		{
			internal VirtualTexture asset;

			internal int size;

			internal int mipCount;

			internal List<ushort[]> mipAddr;
		}

		private AmplifyTextureCamera m_runtime;

		private const int MaxTableMipCount = 12;

		private int m_maxMipCount;

		private AssetTable[] m_tables;

		private Dictionary<int, Queue<ushort[]>> m_mipAddrPool;

		private int m_width;

		private int m_height;

		private Dictionary<int, RenderTexture[]> m_renderTexPool;

		private RenderTexture m_renderTex;

		private RenderTexture m_renderTexClone;

		private Texture2D m_dummyTex;

		private Material m_fillMat;

		private Material m_blitMat;

		private Mesh m_quad;

		private MaterialPropertyBlock m_block;

		private static readonly int[] PreallocMipAddr;

		public RenderTexture RenderTex => null;

		internal PhysicalTable(AmplifyTextureCamera runtime)
		{
		}

		private void AllocateTableTexture(int width, int height, out RenderTexture renderTex, out RenderTexture renderTexClone)
		{
			renderTex = null;
			renderTexClone = null;
		}

		private void AllocateTableTexturePools()
		{
		}

		private void AllocateTablePools()
		{
		}

		private Queue<ushort[]> GetMipAddrPool(int size)
		{
			return null;
		}

		private ushort[] ReserveMipAddr(int size)
		{
			return null;
		}

		private void ReleaseMipAddr(ushort[] mipAddr)
		{
		}

		private void UpdateTableTextures()
		{
		}

		internal void UpdateTables()
		{
		}

		internal void Reset()
		{
		}

		internal void DestroyTableTextures()
		{
		}

		internal void Destroy()
		{
		}

		internal Mesh CreateQuadMesh()
		{
			return null;
		}

		internal void CheckCreateDebugTextures()
		{
		}

		internal void Clear()
		{
		}

		internal bool LostData()
		{
			return false;
		}

		private void DrawTableFill(CommandBuffer command, Rect rect, Vector4 value, AssetTable table, int mip, int pass)
		{
		}

		internal void AddPage(CommandBuffer command, Page page)
		{
		}

		internal void RemovePage(CommandBuffer command, Page page)
		{
		}

		private void DebugRenderTable(RenderTexture tex, float x, float y, float width, float height, int pass)
		{
		}

		public void DebugRender(float targetSize)
		{
		}
	}
}

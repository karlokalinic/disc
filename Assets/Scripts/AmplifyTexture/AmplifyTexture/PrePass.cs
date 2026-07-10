using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

namespace AmplifyTexture
{
	[Serializable]
	public sealed class PrePass
	{
		internal delegate void OnPrePassResizeEvent();

		private const int MaxWidth = 256;

		private const int MaxHeight = 256;

		private RenderTexture m_renderTex;

		private Texture2D m_readTex;

		private int m_width;

		private int m_height;

		private Camera m_referenceCamera;

		private Camera m_prePassCamera;

		private string m_prePassCameraName;

		private PrePassReadback m_prePassReadback;

		private Material m_prePassMaterial;

		private Camera m_lookThroughCamera;

		private AmplifyTextureCamera m_runtime;

		private Color32[] m_pixelColors;

		private Rect m_pixelRect;

		private uint m_pixelCount;

		private PrePassHashEntry[] m_hashEntries;

		private ushort[] m_pageRefs;

		private ushort m_pageRefCount;

		private uint m_maxPageRefs;

		private Page[] m_requests;

		private Page[] m_requestsTemp;

		private uint[] m_sortValues;

		private uint[] m_sortRemap;

		private uint[] m_sortRemapTemp;

		private const int RefineLODMinFrameCount = 0;

		private float refineLODIncrement;

		private int refineLODLastFrame;

		private const uint HASH_BUCKET_COUNT = 1048583u;

		private ushort m_hashEntryCount;

		private ushort[] m_hashBuckets;

		private uint[] m_pixelValues;

		private Color32[] m_colors;

		private uint m_assetCount;

		private AssetDesc[] m_assetDescTable;

		private AsyncGPUReadbackRequest request;

		private Queue<AsyncGPUReadbackRequest> readbackRequests;

		private IntPtr nativeHistogramInst;

		private IntPtr nativeReadbackInst;

		internal OnPrePassResizeEvent OnPrePassResize;

		private uint[] histogram;

		private uint[] offset;

		internal RenderTexture RenderTex => null;

		internal Texture2D ReadTex => null;

		internal int Width => 0;

		internal int Height => 0;

		internal Camera ReferenceCamera => null;

		internal Camera PrePassCamera => null;

		internal Camera LookThroughCamera => null;

		internal AmplifyTextureCamera Runtime => null;

		internal Page[] Requests => null;

		internal PrePass(AmplifyTextureCamera runtime)
		{
		}

		internal void Reset()
		{
		}

		internal void Destroy()
		{
		}

		private void DestroyPrePassCameraObject(GameObject obj)
		{
		}

		private void DestroyObjects()
		{
		}

		private void DestroyTextures()
		{
		}

		internal bool LostData()
		{
			return false;
		}

		private void UpdateLookThroughParams(Camera ppCam, Camera lookCam, float far, float fov, float orthoSize)
		{
		}

		internal void UpdateCamera()
		{
		}

		public void ForceLookThrough(Camera camera)
		{
		}

		public void IssuePrePassRead()
		{
		}

		public void RenderAndReadback(bool preload)
		{
		}

		public void BuildHistogram()
		{
		}

		private void BuildHistogramFallback(Color32[] pixelColors)
		{
		}

		internal int GenerateRequests(PhysicalCache cache, out int lowestMipCount, bool preload)
		{
			lowestMipCount = default(int);
			return 0;
		}

		private void SortPageRequests(int num)
		{
		}

		internal void DebugRender(int targetSize)
		{
		}

		private void RadixSortU8(uint[] values, uint[] remap, uint num)
		{
		}

		private void RadixSortU24(uint[] values, uint[] remap, uint[] remapTemp, uint num)
		{
		}
	}
}

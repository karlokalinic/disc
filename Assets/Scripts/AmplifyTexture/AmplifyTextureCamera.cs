using System.Collections.Generic;
using AmplifyTexture;
using UnityEngine;
using UnityEngine.Experimental.Rendering;

[ExecuteInEditMode]
public class AmplifyTextureCamera : MonoBehaviour
{
	[SerializeField]
	private PhysicalCache.Size m_cacheSize;

	[SerializeField]
	private bool m_cacheCompression;

	[SerializeField]
	private int m_pagesPerFrame;

	[SerializeField]
	private int m_streamingThreads;

	[SerializeField]
	private FilterMode m_filter;

	[SerializeField]
	private int m_anisoLevel;

	[SerializeField]
	private PrePassSize m_prePassSize;

	[SerializeField]
	private PrePassFov m_prePassFov;

	[SerializeField]
	private PrePassOrtho m_prePassOrtho;

	[SerializeField]
	private PrePassFarPlane m_prePassFarPlane;

	[SerializeField]
	private PrePassAdvanced m_prePassAdvanced;

	[SerializeField]
	private DebugDisplay m_debugDisplay;

	[HideInInspector]
	[SerializeField]
	private PhysicalCache.Size m_backupCacheSize;

	[HideInInspector]
	[SerializeField]
	private bool m_backupCacheCompression;

	[SerializeField]
	[HideInInspector]
	private int m_cacheWidth;

	[SerializeField]
	[HideInInspector]
	private int m_cacheHeight;

	[SerializeField]
	[HideInInspector]
	private Camera m_camera;

	private float m_lodBias;

	private GraphicsFormat m_compFormatRGB;

	private GraphicsFormat m_compFormatRG;

	private GraphicsFormat m_rawFormatRG;

	private bool m_cacheIsCompressed;

	private List<VirtualTexture> m_assets;

	private PrePass m_prePass;

	private PhysicalTable m_physicalTable;

	private PhysicalCache m_physicalCache;

	private PageStreamer m_pageStreamer;

	private static Vector4[] m_prePassJitterOffsets;

	private int m_prePassJitterIndex;

	private int m_screenWidth;

	private int m_screenHeight;

	private bool m_preload;

	private int m_pageUploadCount;

	private float m_scheduledRestartTime;

	private bool m_scheduledRestart;

	private int m_pagesThisFrame;

	private bool m_initialized;

	private AssetDesc[] m_assetDescTable;

	public PhysicalCache.Size CacheSize
	{
		get
		{
			return default(PhysicalCache.Size);
		}
		set
		{
		}
	}

	public bool CacheCompression
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public int PagesPerFrame => 0;

	public int StreamingThreads
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public FilterMode Filter => default(FilterMode);

	public uint AnisoLevel => 0u;

	public PrePassSize PrePassSize => default(PrePassSize);

	public PrePassFov PrePassFov => default(PrePassFov);

	public PrePassOrtho PrePassOrtho => default(PrePassOrtho);

	public PrePassFarPlane PrePassFarPlane => default(PrePassFarPlane);

	public PrePassAdvanced PrePassAdvanced => default(PrePassAdvanced);

	public DebugDisplay DebugDisplay => default(DebugDisplay);

	public int CacheWidth => 0;

	public int CacheHeight => 0;

	public Camera Camera
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public float LodBias
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public GraphicsFormat PageCompFormatRGB => default(GraphicsFormat);

	public GraphicsFormat PageCompFormatRG => default(GraphicsFormat);

	public GraphicsFormat PageRawFormatRG => default(GraphicsFormat);

	public bool CacheIsCompressed => false;

	public List<VirtualTexture> Assets => null;

	public PrePass PrePass => null;

	public PhysicalTable PhysicalTable => null;

	public PhysicalCache PhysicalCache => null;

	internal PageStreamer PageStreamer => null;

	public bool IsInitialized => false;

	public AssetDesc[] AssetDescTable => null;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void InitializePlatformRuntimeSettings()
	{
	}

	public static void ComputeCacheSize(int screenWidth, int screenHeight, PhysicalCache.Size cacheSize, out int cacheWidth, out int cacheHeight)
	{
		cacheWidth = default(int);
		cacheHeight = default(int);
	}

	internal void InternalInitialize(EditorRuntimeProperties editorProps)
	{
	}

	internal void UpdateAssetDescTable()
	{
	}

	internal void InternalReset()
	{
	}

	internal void InternalFinalize()
	{
	}

	public void UpdateEditorCameraProperties(Camera sceneCamera, EditorRuntimeProperties editorRuntime)
	{
	}

	private void EnsureKeywordState(string keyword, bool state)
	{
	}

	internal void SetGlobalShaderParams()
	{
	}

	internal bool CheckDataIntegrity()
	{
		return false;
	}

	private bool UpdateCacheSize(PhysicalCache.Size cacheSize)
	{
		return false;
	}

	private bool UpdateCacheCompression(bool cacheCompression)
	{
		return false;
	}

	internal int ForegroundUpdateImmediate()
	{
		return 0;
	}

	private bool StreamPages(bool preload, out int remaining)
	{
		remaining = default(int);
		return false;
	}

	public void Warmup(float maxWarmupDuration = 1f)
	{
	}

	private void OnPreRender()
	{
	}
}

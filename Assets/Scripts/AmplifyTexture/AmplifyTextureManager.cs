using System;
using System.Collections.Generic;
using AmplifyTexture;
using UnityEngine;

[ExecuteInEditMode]
public class AmplifyTextureManager : MonoBehaviour
{
	private enum RuntimeState
	{
		None = 0,
		Editing = 1,
		Playing = 2
	}

	public enum UpdateAssetsEvent
	{
		Error = 0,
		None = 1,
		RestartToUpdate = 2,
		StopToRebuild = 3
	}

	public List<VirtualTextureCollection> VirtualTextureCollections;

	[SerializeField]
	private List<VirtualTexture> m_virtualTextures;

	[SerializeField]
	private List<Camera> m_targetCameras;

	[SerializeField]
	private LayerMask m_cullingMask;

	[SerializeField]
	private EditorRuntimeProperties m_editorRuntime;

	private bool m_enableProfiling;

	private Camera m_editorCamera;

	private AmplifyTextureCamera m_editorCameraRuntime;

	public const int MaxVirtualTexturesPerProject = 256;

	public const int MaxVirtualTexturesPerScene = 16;

	public const string ReadmePath = "AmplifyTexture/Readme.txt";

	[HideInInspector]
	public Texture2D m_emptyPageTable;

	internal static int SceneViewWidth;

	internal static int SceneViewHeight;

	private static List<AmplifyTextureCamera> m_runtimeList;

	[NonSerialized]
	[HideInInspector]
	private List<VirtualTexture> m_currentVirtualTextures;

	[NonSerialized]
	[HideInInspector]
	private List<VirtualTexture> m_assets;

	[NonSerialized]
	[HideInInspector]
	private List<int> m_cachedAssetIndices;

	[NonSerialized]
	[HideInInspector]
	private Texture2D m_pageTableDescTex;

	private bool m_started;

	private bool m_reset;

	private RuntimeState m_runtimeState;

	private bool m_gameViewAsEditorReference;

	private static AmplifyTextureManager m_instance;

	private static bool m_isOpenGL;

	private Dictionary<string, VirtualTextureCollection> m_collections;

	private VirtualTextureCollection m_activeCollection;

	private const int HardcodedLUTSize = 64;

	private Color32[] m_pageTableDescPixels;

	private Vector4[] m_remapIndices;

	private static bool m_awake;

	public List<VirtualTexture> VirtualTextures
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public List<Camera> TargetCameras => null;

	public LayerMask CullingMask => default(LayerMask);

	public EditorRuntimeProperties EditorRuntime => null;

	public bool EnableProfiling => false;

	public AmplifyTextureCamera EditorCameraRuntime => null;

	public bool EnabledAndActive => false;

	internal static List<AmplifyTextureCamera> RuntimeList => null;

	public List<VirtualTexture> Assets => null;

	public bool Started => false;

	public bool IsReset => false;

	public static AmplifyTextureManager Instance => null;

	public static bool IsOpenGL => false;

	public VirtualTextureCollection ActiveCollection => null;

	public static bool IsAwake => false;

	private void OnApplicationQuit()
	{
	}

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public bool SetActiveCollection(string uniqueName)
	{
		return false;
	}

	public void Warmup(float maxWarmupDuration = 1f)
	{
	}

	private void CheckPageTableDescTexture(int width)
	{
	}

	private void DestroyPageTableDescTexture()
	{
	}

	private void CreatePageTableDescTexture(List<VirtualTexture> assets)
	{
	}

	private void InitializeCollections()
	{
	}

	public void InternalStart()
	{
	}

	public void InternalStop()
	{
	}

	public void ResetGlobalShaderParams()
	{
	}

	public void Reset()
	{
	}

	internal static void Register(AmplifyTextureCamera runtime)
	{
	}

	internal static void Unregister(AmplifyTextureCamera runtime)
	{
	}

	private void UpdatePageTables(List<VirtualTexture> assets)
	{
	}

	private UpdateAssetsEvent UpdateAssets()
	{
		return default(UpdateAssetsEvent);
	}

	private void InternalUpdate()
	{
	}

	private Camera FindCurrentGameViewCamera()
	{
		return null;
	}

	private bool UpdateRuntimes()
	{
		return false;
	}

	private void UpdateState()
	{
	}

	private bool CreateEditorRuntime()
	{
		return false;
	}

	private void DestroyEditorRuntime()
	{
	}

	public void Update()
	{
	}

	private void OnDrawGizmos()
	{
	}

	public void SignalGameViewAsEditorReference(bool state)
	{
	}
}

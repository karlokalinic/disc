using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AmplifyTexture;
using UnityEngine;

[Serializable]
public class VirtualTexture : ScriptableObject
{
	public delegate void OnFinishBuildHandler(VirtualTexture asset);

	public const int MaxAssetIndex = 255;

	[HideInInspector]
	[SerializeField]
	private VirtualSize m_virtualSize;

	[HideInInspector]
	[SerializeField]
	private MipFilter m_mipFilter;

	[HideInInspector]
	[SerializeField]
	private int m_uvCoordSet;

	[HideInInspector]
	[SerializeField]
	public LayoutPreset m_layoutPreset;

	[HideInInspector]
	[SerializeField]
	public LayoutSettings m_layoutSettings;

	[SerializeField]
	[HideInInspector]
	public VirtualSize m_editVirtualSize;

	[HideInInspector]
	[SerializeField]
	public MipFilter m_editMipFilter;

	[HideInInspector]
	[SerializeField]
	public int m_editUVCoordSet;

	[HideInInspector]
	[SerializeField]
	public LayoutPreset m_editLayoutPreset;

	[HideInInspector]
	[SerializeField]
	public LayoutSettings m_editLayoutSettings;

	[HideInInspector]
	[SerializeField]
	private byte[] m_signature;

	[HideInInspector]
	[SerializeField]
	private VersionInfo m_version;

	[HideInInspector]
	[SerializeField]
	private string m_hashName;

	[HideInInspector]
	[SerializeField]
	private int m_assetIndex;

	[SerializeField]
	[HideInInspector]
	private int m_physicalTableSize;

	[HideInInspector]
	[SerializeField]
	private int m_physicalTableArea;

	[SerializeField]
	[HideInInspector]
	private int m_pageBlockSize;

	[SerializeField]
	[HideInInspector]
	private int m_mipCount;

	[SerializeField]
	[HideInInspector]
	private int m_channelCount;

	[SerializeField]
	[HideInInspector]
	public int m_diffuseLayerIndex;

	[SerializeField]
	[HideInInspector]
	public int m_normalLayerIndex;

	[SerializeField]
	[HideInInspector]
	public int m_occlusionLayerIndex;

	[SerializeField]
	[HideInInspector]
	public int m_displacementLayerIndex;

	[HideInInspector]
	[SerializeField]
	public int m_specularLayerIndex;

	[HideInInspector]
	[SerializeField]
	public TextureLayer[] m_textureLayers;

	[HideInInspector]
	[SerializeField]
	public List<string> m_materialFolders;

	public const int MaxMipCount = 8;

	public const int TileSize = 128;

	public const int HalfTileSize = 64;

	public const int DoubleTileSize = 256;

	public const int BorderSize = 4;

	public const int DoubleBorderSize = 8;

	public const int PageSize = 136;

	public const int PageChannelLength = 18496;

	public const int TileChannelLength = 16384;

	[HideInInspector]
	[SerializeField]
	private TexturePacker m_packer;

	[HideInInspector]
	[SerializeField]
	private TextureCollection m_collection;

	[HideInInspector]
	[SerializeField]
	public int m_compressedSizeKB;

	[SerializeField]
	[HideInInspector]
	public int m_uncompressedSizeKB;

	[HideInInspector]
	[SerializeField]
	public float m_areaUsePercentage;

	[HideInInspector]
	[SerializeField]
	public float m_borderWastePercentage;

	[NonSerialized]
	[HideInInspector]
	public Vector2 m_pageTableOffset;

	[HideInInspector]
	[SerializeField]
	public VirtualSize m_savedVirtualSize;

	[SerializeField]
	[HideInInspector]
	public int m_savedPageTableSize;

	[SerializeField]
	[HideInInspector]
	public Vector2 m_savedPageTableScale;

	[HideInInspector]
	[SerializeField]
	public Vector2 m_savedPageTableOffset;

	private bool m_dirty;

	[HideInInspector]
	[SerializeField]
	private PageFile m_pageFile;

	private PageFile2 m_pageFile2;

	public VirtualSize VirtualSize
	{
		get
		{
			return default(VirtualSize);
		}
		set
		{
		}
	}

	public MipFilter MipFilter
	{
		get
		{
			return default(MipFilter);
		}
		set
		{
		}
	}

	public int UVCoordSet
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public LayoutPreset LayoutPreset
	{
		get
		{
			return default(LayoutPreset);
		}
		set
		{
		}
	}

	public LayoutSettings LayoutSettings
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool UseAlpha
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool UseNormal
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool UseOcclusion
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool UseDisplacement
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool UseSpecular
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool CanUseOcclusion => false;

	public bool CanUseDisplacement => false;

	public bool CanUseSpecular => false;

	public int AssetIndex
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public byte[] Signature => null;

	public string SignatureString => null;

	public VersionInfo Version => null;

	public string HashName => null;

	public int PageTableSize => 0;

	public int PageTableArea => 0;

	public int PageBlockSize => 0;

	public int MipCount => 0;

	public int ChannelCount => 0;

	public TexturePacker Packer => null;

	public TextureCollection Collection
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int CompressedSizeKB => 0;

	public int UncompressedSizeKB => 0;

	public float AreaUsePercentage => 0f;

	public float BorderWastePercentage => 0f;

	public bool Dirty => false;

	public PageFile PageFile => null;

	public string PageFilePath => null;

	public PageFile2 PageFile2 => null;

	public event OnFinishBuildHandler OnFinishBuild
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public bool ValidatePageFile()
	{
		return false;
	}

	internal void InternalStart()
	{
	}

	internal void InternalStop()
	{
	}

	public bool CheckConsistency()
	{
		return false;
	}

	public void OnEnable()
	{
	}

	public void OnDisable()
	{
	}

	public void Initialize()
	{
	}

	public NativeRuntime.PlaneDesc[] GeneratePlanes()
	{
		return null;
	}

	public void GenerateTextureLayers()
	{
	}

	internal void GenerateSignature()
	{
	}

	public bool CheckPageFileSignature()
	{
		return false;
	}

	public void UpdateProperties()
	{
	}

	public void RequestRebuild()
	{
	}

	public void FinishBuild()
	{
	}

	public float ComputeAreaUsePercentage()
	{
		return 0f;
	}

	public float ComputeBorderWastePercentage()
	{
		return 0f;
	}

	public static int GetMaxPageBlockSize(bool compressed)
	{
		return 0;
	}

	public void DebugInfo()
	{
	}
}

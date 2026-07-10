using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

namespace AddressablesTools
{
	public class AssetBundleManager : MonoBehaviour
	{
		public enum LogMode
		{
			All = 0,
			JustErrors = 1
		}

		public enum LogType
		{
			Info = 0,
			Warning = 1,
			Error = 2
		}

		private static LogMode m_LogMode;

		private static string m_BaseDownloadingURL;

		private static string[] m_ActiveVariants;

		private static AssetBundleManifest m_AssetBundleManifest;

		private static Dictionary<string, LoadedAssetBundle> m_LoadedAssetBundles;

		private static Dictionary<string, UnityWebRequest> m_DownloadingWWWs;

		private static Dictionary<string, string> m_DownloadingErrors;

		private static List<AssetBundleLoadOperation> m_InProgressOperations;

		private static Dictionary<string, string[]> m_Dependencies;

		private List<string> keysToRemove;

		public static LogMode logMode
		{
			get
			{
				return default(LogMode);
			}
			set
			{
			}
		}

		public static string BaseDownloadingURL
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static string[] ActiveVariants
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static AssetBundleManifest AssetBundleManifestObject
		{
			set
			{
			}
		}

		private static void Log(LogType logType, string text)
		{
		}

		private static string GetStreamingAssetsPath()
		{
			return null;
		}

		public static void SetSourceAssetBundleDirectory(string relativePath)
		{
		}

		public static void SetSourceAssetBundleURL(string absolutePath)
		{
		}

		public static void SetDevelopmentAssetBundleServer()
		{
		}

		public static LoadedAssetBundle GetLoadedAssetBundle(string assetBundleName, out string error)
		{
			error = null;
			return null;
		}

		public static AssetBundleLoadManifestOperation Initialize()
		{
			return null;
		}

		public static AssetBundleLoadManifestOperation Initialize(string manifestAssetBundleName)
		{
			return null;
		}

		protected static void LoadAssetBundle(string assetBundleName, bool isLoadingAssetBundleManifest = false)
		{
		}

		protected static string RemapVariantName(string assetBundleName)
		{
			return null;
		}

		protected static bool LoadAssetBundleInternal(string assetBundleName, bool isLoadingAssetBundleManifest)
		{
			return false;
		}

		protected static void LoadDependencies(string assetBundleName)
		{
		}

		public static void UnloadAssetBundle(string assetBundleName)
		{
		}

		protected static void UnloadDependencies(string assetBundleName)
		{
		}

		protected static void UnloadAssetBundleInternal(string assetBundleName)
		{
		}

		private void Update()
		{
		}

		public static AssetBundleLoadAssetOperation LoadAssetAsync(string assetBundleName, string assetName, Type type)
		{
			return null;
		}

		public static AssetBundleLoadOperation LoadLevelAsync(string assetBundleName, string levelName, bool isAdditive)
		{
			return null;
		}
	}
}

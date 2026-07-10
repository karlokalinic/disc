using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace I2.Loc
{
	public class LocalizationAssetBundlesManager : RegisterBundlesManager
	{
		private static string fontsBundleNameFormat;

		private const string defaultImagesBundleNameFormat = "images/{0}";

		private const string dyslexicImagesBundlenameFormat = "images_dyslexic/{0}";

		private static string lockitsBundleNameFormat;

		private static bool dyslexic;

		private static string fontsLockitFormat;

		private static string imagesLockitFormat;

		private static string generalLockitFormat;

		private static string dialoguesLockitFormat;

		private string sharedBundlePath;

		private string englishFontBundlePath;

		private string englishImageBundlePath;

		private string englishLockitBundlePath;

		private Dictionary<string, AssetBundle> loadedBundles;

		private Dictionary<string, LanguageSourceAsset> loadedLockits;

		private HashSet<string> bundlesToUnload;

		private AssetBundle sharedBundle;

		private Coroutine unloadCoroutine;

		public static LocalizationAssetBundlesManager Instance { get; private set; }

		private static string ImagesBundleNameFormat => null;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		public override UnityEngine.Object LoadFromBundle<T>(string assetName, Type assetType)
		{
			return null;
		}

		public T LoadFromFontBundle<T>(string assetName, string currentLanguage) where T : UnityEngine.Object
		{
			return null;
		}

		public T LoadFromImageBundle<T>(string path, string currentLanguage) where T : UnityEngine.Object
		{
			return null;
		}

		public AssetBundle GetFontBundleForLanguage(string languageName)
		{
			return null;
		}

		public AssetBundle GetImageBundleForLanguage(string languageName)
		{
			return null;
		}

		public void LoadBundlesForLanguage(string languageName)
		{
		}

		public void UnloadBundleForLanguage(string languageName, bool immediate = false)
		{
		}

		private IEnumerator DelayedUnloadBundles()
		{
			return null;
		}

		private static string GetFontBundlePath(string languageName)
		{
			return null;
		}

		private static string GetAssetBundleNameForFontBundle(string languageName)
		{
			return null;
		}

		private static string GetImageBundlePath(string languageName)
		{
			return null;
		}

		private static string GetAssetBundleNameForImageBundle(string languageName)
		{
			return null;
		}

		private static string GetLockitBundlePath(string languageName)
		{
			return null;
		}

		private static string GetAssetBundleNameForLockitBundle(string languageName)
		{
			return null;
		}

		public void DyslexicImageBundles(bool useDyslexicImages, List<string> languages)
		{
		}
	}
}

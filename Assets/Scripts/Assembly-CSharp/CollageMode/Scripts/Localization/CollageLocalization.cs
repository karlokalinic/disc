using System.Collections.Generic;
using I2.Loc;
using UnityEngine;

namespace CollageMode.Scripts.Localization
{
	public static class CollageLocalization
	{
		private const string CollageFolder = "collage";

		private const string CollageBundle = "shared";

		private const string LocalizationAssetName = "CollageModeLockit";

		private const string TermPrefix = "Collage/";

		private static readonly string[] LanguagesWithBundle;

		private static List<AssetBundle> loadedBundles;

		private static List<LanguageSourceAsset> loadedLocalization;

		public static void LoadLocalization()
		{
		}

		public static void UnloadLocalization()
		{
		}

		public static string GetTranslation(string partialTerm)
		{
			return null;
		}

		public static string GetEnglishTranslation(string partialTerm)
		{
			return null;
		}

		public static void SetCollageTerm(this Localize localize, string term)
		{
		}

		public static T LoadFromCollageBundle<T>(string assetName) where T : Object
		{
			return null;
		}

		private static string GetBundlePath(string bundleName)
		{
			return null;
		}
	}
}

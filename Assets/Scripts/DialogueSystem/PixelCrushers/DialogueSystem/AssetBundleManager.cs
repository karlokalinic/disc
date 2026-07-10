using System;
using System.Collections.Generic;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	public class AssetBundleManager
	{
		private HashSet<AssetBundle> m_bundles;

		public void RegisterAssetBundle(AssetBundle bundle)
		{
		}

		public void UnregisterAssetBundle(AssetBundle bundle)
		{
		}

		public UnityEngine.Object Load(string name)
		{
			return null;
		}

		public UnityEngine.Object Load(string name, Type type)
		{
			return null;
		}

		private UnityEngine.Object LoadFromBundle(AssetBundle bundle, string name)
		{
			return null;
		}

		private UnityEngine.Object LoadFromBundle(AssetBundle bundle, string name, Type type)
		{
			return null;
		}
	}
}

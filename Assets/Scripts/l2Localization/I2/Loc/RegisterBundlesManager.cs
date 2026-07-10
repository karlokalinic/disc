using System;
using UnityEngine;

namespace I2.Loc
{
	public class RegisterBundlesManager : MonoBehaviour, IResourceManager_Bundles
	{
		public void OnEnable()
		{
		}

		public void OnDisable()
		{
		}

		public virtual UnityEngine.Object LoadFromBundle<T>(string path, Type assetType) where T : UnityEngine.Object
		{
			return null;
		}
	}
}

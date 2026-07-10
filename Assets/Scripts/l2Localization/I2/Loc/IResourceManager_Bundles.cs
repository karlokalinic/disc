using System;
using UnityEngine;

namespace I2.Loc
{
	public interface IResourceManager_Bundles
	{
		UnityEngine.Object LoadFromBundle<T>(string path, Type assetType) where T : UnityEngine.Object;
	}
}

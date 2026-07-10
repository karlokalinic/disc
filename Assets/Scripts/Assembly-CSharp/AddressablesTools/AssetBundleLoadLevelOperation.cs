using UnityEngine;

namespace AddressablesTools
{
	public class AssetBundleLoadLevelOperation : AssetBundleLoadOperation
	{
		protected string m_AssetBundleName;

		protected string m_LevelName;

		protected bool m_IsAdditive;

		protected string m_DownloadingError;

		protected AsyncOperation m_Request;

		public AssetBundleLoadLevelOperation(string assetbundleName, string levelName, bool isAdditive)
		{
		}

		public override bool Update()
		{
			return false;
		}

		public override bool IsDone()
		{
			return false;
		}
	}
}

using System.Collections;
using UnityEngine;

public class LoadingScreenBundleManager : MonoBehaviour
{
	private AssetBundle m_loadingScreenBundle;

	private bool m_loadingBundle;

	private const string LoadingScreenPrefix = "[Loading Screen]: ";

	private static LoadingScreenBundleManager m_instance;

	private string m_bundleFilepath;

	public static LoadingScreenBundleManager Instance => null;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private IEnumerator LoadLoadingScreens()
	{
		return null;
	}

	public void LoadNewScreen()
	{
	}

	public void ReleaseLoadingBundle()
	{
	}
}

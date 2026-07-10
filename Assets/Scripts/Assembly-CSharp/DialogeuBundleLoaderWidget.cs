using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class DialogeuBundleLoaderWidget : LiteSingleton<DialogeuBundleLoaderWidget>
{
	public RectTransform marker;

	public RectTransform spinner;

	public Text nameText;

	public Text versionText;

	public Button[] buttons;

	public void OnOptionChange(int mode)
	{
	}

	private bool CheckLocalXmlBundleExists()
	{
		return false;
	}

	private bool CheckLocalFeldBundleExists()
	{
		return false;
	}

	private IEnumerator DelayedLoad()
	{
		return null;
	}

	private void OnEnable()
	{
	}

	private void SetMarker()
	{
	}

	private void ShowVersion()
	{
	}

	private void ShowName()
	{
	}

	private void Update()
	{
	}
}

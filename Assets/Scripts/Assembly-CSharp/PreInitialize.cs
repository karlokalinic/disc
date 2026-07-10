using System.Collections;
using FortressOccident;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PreInitialize : MonoBehaviour
{
	private const string NextScene = "Initialize";

	public TMP_Text loadingText;

	public Image loadingCircle;

	public ApplicationManager applicationManager;

	private const float SplashMaxTime = 5f;

	private float timeCounter;

	private bool loadGamesTrigger;

	private bool loadGamesComplete;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void Update()
	{
	}

	private void SetLoadingLanguage(string savedLanguage)
	{
	}

	private void SetLoadingAlpha(float alpha)
	{
	}

	private IEnumerator WaitAndStartTheGame()
	{
		return null;
	}

	private bool SplashScreenFinished()
	{
		return false;
	}

	private bool CanCancel()
	{
		return false;
	}

	private bool CanLoadGameData()
	{
		return false;
	}

	private IEnumerator FadeLoadingMessage()
	{
		return null;
	}

	private IEnumerator LoadGameData()
	{
		return null;
	}

	public static string GetStartupLanguage()
	{
		return null;
	}
}

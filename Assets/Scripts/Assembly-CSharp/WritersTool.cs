using System.Collections;
using Sunshine;
using Voidforge;

public class WritersTool : VoidElement
{
	public static WritersTool singleton;

	public WritersPanel writersPanel;

	private bool showButtonsArePressed;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public bool ToggleWritersPanel()
	{
		return false;
	}

	private bool ToggleTeleportMode()
	{
		return false;
	}

	private bool TakeNormalScreenshot()
	{
		return false;
	}

	private bool TakeBigScreenshot()
	{
		return false;
	}

	private bool ShowCutsceneView()
	{
		return false;
	}

	private bool ShowDialogueView()
	{
		return false;
	}

	private bool ForceCenterCamera()
	{
		return false;
	}

	private void TakeScreenshot(int superSize)
	{
	}

	private bool TweenCamera()
	{
		return false;
	}

	private IEnumerator StupidUnityDoesntSupportAnonymousCoroutines(TweenCamera tween)
	{
		return null;
	}
}

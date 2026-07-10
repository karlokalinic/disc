using System.Collections.Generic;
using Voidforge;

public class TutorialMessage
{
	private readonly string localizationTerm;

	private readonly int duration;

	private readonly TUTORIAL_TYPE tutorialType;

	private readonly int delay;

	private Timer delayTimer;

	private bool isObsolete;

	public static Dictionary<TUTORIAL_TYPE, TutorialMessage> initializeTutorialMessages()
	{
		return null;
	}

	private TutorialMessage(TUTORIAL_TYPE tutorialType, string localizationTerm, int delay)
	{
	}

	public void StartTimer()
	{
	}

	private void showTutorialMessage()
	{
	}

	private void checkIfObsolete()
	{
	}

	public void SetObsolete(bool isObsolete, bool doSave = true)
	{
	}

	public void Pause()
	{
	}

	public void Unpause()
	{
	}
}

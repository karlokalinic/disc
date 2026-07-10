using System.Collections.Generic;
using UnityEngine;

public class TutorialTracker : MonoBehaviour
{
	private static Dictionary<TUTORIAL_TYPE, TutorialMessage> TUTORIAL_MESSAGE_MAP;

	public static TutorialTracker INSTANCE;

	public void Awake()
	{
	}

	public void Start()
	{
	}

	public void StartTimerForTutorial(TUTORIAL_TYPE tutorialType)
	{
	}

	public void SetTutorialObsolete(TUTORIAL_TYPE tutorialType)
	{
	}

	public void PauseAll()
	{
	}

	public void UnpauseAll()
	{
	}

	public void ResetAll()
	{
	}

	private TutorialMessage GetTutorialMessage(TUTORIAL_TYPE tutorialType)
	{
		return null;
	}
}

using System;
using PixelCrushers.DialogueSystem.SequencerCommands;

public static class SequenceCommander
{
	public static int sequencerCommands;

	public static bool nextResponses;

	public static bool previousResponses;

	public static ContState delayedContinueState;

	public static Action<string, string[]> OnSequenceStarted;

	public static Action OnSequenceFinished;

	public static void ReadyCutscene(string dialogueString, string[] sequenceCommands, bool responseOptions)
	{
	}

	public static bool RequestContinueButton(SequencerCommand command)
	{
		return false;
	}

	private static bool RequestContinueButton()
	{
		return false;
	}

	public static void EmergencyForceDeblock()
	{
	}

	public static bool LastInQueue()
	{
		return false;
	}
}

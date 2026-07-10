using PixelCrushers.DialogueSystem;
using Sunshine.Metric;
using UnityEngine;
using UnityEngine.UI;

public class WhiteCheckDebug : MonoBehaviour
{
	[SerializeField]
	private InputField conversationInput;

	[SerializeField]
	private InputField entryInput;

	private const string difficultyFieldName = "DifficultyWhite";

	public void AddWhiteCheck()
	{
	}

	private static void AddWhiteCheckWithEntry(DialogueEntry entry)
	{
	}

	private static WhiteCheck ConstructAWhiteCheck(string flagName, DialogueEntry entry, CheckResult checkResult, Actor actor)
	{
		return null;
	}
}

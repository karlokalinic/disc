using UnityEngine;
using UnityEngine.UI;

public class LastDialogueButton : MonoBehaviour
{
	private const string PREFNAME = "LastConversation";

	public Text titleText;

	private static Text text;

	protected void OnEnable()
	{
	}

	public static void SaveLast()
	{
	}

	public string GetLast()
	{
		return null;
	}

	public void RunLast()
	{
	}

	private static void UpdateTitleText(string title)
	{
	}
}

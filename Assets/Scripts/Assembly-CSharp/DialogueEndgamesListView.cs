using PixelCrushers.DialogueSystem;
using UnityEngine;
using UnityEngine.UI;

public class DialogueEndgamesListView : GenericListView
{
	private const char TITLE_DELIMITER = '/';

	protected override void PopulateList()
	{
	}

	private void CreateEndgameButtonsFromConversation(Conversation conv, RectTransform root)
	{
	}

	private void CreateButton(DialogueEntry entry, RectTransform root)
	{
	}

	private void AddEndgameTrigger(Button button, string type)
	{
	}

	protected override void OnEnable()
	{
	}

	protected override char GetSeparator()
	{
		return '\0';
	}
}

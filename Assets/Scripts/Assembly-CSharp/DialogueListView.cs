using PixelCrushers.DialogueSystem;
using UnityEngine;
using UnityEngine.UI;

public class DialogueListView : GenericListView
{
	private const char TITLE_DELIMITER = '/';

	protected override void PopulateList()
	{
	}

	private Button CreateButton(Conversation conv, RectTransform root)
	{
		return null;
	}

	private void AddConversationTrigger(Button button, string conversation, int actorID)
	{
	}

	private void AddConversationActors(ConversationTrigger trigger, int actorID)
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

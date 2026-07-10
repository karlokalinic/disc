using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	public abstract class ConversationStarter : DialogueEventStarter
	{
		public string conversation;

		public Condition condition;

		public bool skipIfNoValidEntries;

		public bool exclusive;

		public Transform conversant;

		private bool tryingToStart;

		[HideInInspector]
		public bool useConversationTitlePicker;

		[HideInInspector]
		public DialogueDatabase selectedDatabase;

		public void TryStartConversation(Transform actor)
		{
		}

		public void TryStartConversation(Transform actor, Transform interactor)
		{
		}

		private void StartConversation(Transform actor)
		{
		}
	}
}

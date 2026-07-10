using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	public class ActiveConversationRecord
	{
		public IDialogueUI originalDialogueUI;

		public DisplaySettings originalDisplaySettings;

		public bool isOverrideUIPrefab;

		public Transform actor { get; set; }

		public Transform conversant { get; set; }

		public ConversationController conversationController { get; set; }

		public ConversationModel conversationModel => null;

		public ConversationView conversationView => null;

		public bool isConversationActive => false;

		public Transform Actor
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Transform Conversant
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ConversationController ConversationController
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ConversationModel ConversationModel => null;

		public ConversationView ConversationView => null;

		public bool IsConversationActive => false;
	}
}

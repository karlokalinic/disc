using System;
using PixelCrushers.DialogueSystem.ChatMapper;

namespace PixelCrushers.DialogueSystem
{
	[Serializable]
	public class Link
	{
		public int originConversationID;

		public int originDialogueID;

		public int destinationConversationID;

		public int destinationDialogueID;

		public bool isConnector;

		public ConditionPriority priority;

		public Link()
		{
		}

		public Link(PixelCrushers.DialogueSystem.ChatMapper.Link chatMapperLink)
		{
		}

		public Link(Link sourceLink)
		{
		}

		public Link(int originConversationID, int originDialogueID, int destinationConversationID, int destinationDialogueID)
		{
		}
	}
}

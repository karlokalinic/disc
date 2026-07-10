using System;
using System.Collections.Generic;
using PixelCrushers.DialogueSystem.ChatMapper;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	[Serializable]
	public class Conversation : Asset
	{
		public ConversationOverrideDisplaySettings overrideSettings;

		public string nodeColor;

		public List<DialogueEntry> dialogueEntries;

		[HideInInspector]
		public Vector2 canvasScrollPosition;

		[HideInInspector]
		public float canvasZoom;

		public string Title
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int ActorID
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int ConversantID
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public Conversation()
		{
		}

		public Conversation(Conversation sourceConversation)
		{
		}

		public Conversation(PixelCrushers.DialogueSystem.ChatMapper.Conversation chatMapperConversation, bool putEndSequenceOnLastSplit = true)
		{
		}

		public void Assign(PixelCrushers.DialogueSystem.ChatMapper.Conversation chatMapperConversation, bool putEndSequenceOnLastSplit = true)
		{
		}

		private void AddConversationDialogueEntry(DialogEntry chatMapperEntry)
		{
		}

		public DialogueEntry GetDialogueEntry(string title)
		{
			return null;
		}

		public DialogueEntry GetDialogueEntry(int dialogueEntryID)
		{
			return null;
		}

		public DialogueEntry GetFirstDialogueEntry()
		{
			return null;
		}

		public void SplitPipesIntoEntries(bool putEndSequenceOnLastSplit = true, bool trimWhitespace = false)
		{
		}

		private void SplitEntryAtPipes(int originalEntryIndex, string dialogueText, bool putEndSequenceOnLastSplit, bool trimWhitespace)
		{
		}

		private void PutEndSequenceOnLastSplit(List<DialogueEntry> entries, Field field)
		{
		}

		private DialogueEntry AddNewDialogueEntry(DialogueEntry originalEntry, string dialogueText, int partNum, bool trimWhitespace)
		{
			return null;
		}

		private int GetHighestDialogueEntryID()
		{
			return 0;
		}

		private Link NewLink(DialogueEntry origin, DialogueEntry destination, ConditionPriority priority = ConditionPriority.Normal)
		{
			return null;
		}

		private List<DialogueEntry> CopyDialogueEntries(List<DialogueEntry> sourceEntries)
		{
			return null;
		}
	}
}

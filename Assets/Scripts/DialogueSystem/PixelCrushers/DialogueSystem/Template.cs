using System;
using System.Collections.Generic;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	[Serializable]
	public class Template
	{
		public bool treatItemsAsQuests;

		public List<Field> actorFields;

		public List<Field> itemFields;

		public List<Field> questFields;

		public List<Field> locationFields;

		public List<Field> variableFields;

		public List<Field> conversationFields;

		public List<Field> dialogueEntryFields;

		public List<string> actorPrimaryFieldTitles;

		public List<string> itemPrimaryFieldTitles;

		public List<string> questPrimaryFieldTitles;

		public List<string> locationPrimaryFieldTitles;

		public List<string> variablePrimaryFieldTitles;

		public List<string> conversationPrimaryFieldTitles;

		public List<string> dialogueEntryPrimaryFieldTitles;

		public Color npcLineColor;

		public Color pcLineColor;

		public Color repeatLineColor;

		public static Template FromDefault()
		{
			return null;
		}

		public Actor CreateActor(int id, string name, bool isPlayer)
		{
			return null;
		}

		public Item CreateItem(int id, string name)
		{
			return null;
		}

		public Item CreateQuest(int id, string name)
		{
			return null;
		}

		public Location CreateLocation(int id, string name)
		{
			return null;
		}

		public Variable CreateVariable(int id, string name, string value)
		{
			return null;
		}

		public Variable CreateVariable(int id, string name, string value, FieldType type)
		{
			return null;
		}

		public Conversation CreateConversation(int id, string title)
		{
			return null;
		}

		public DialogueEntry CreateDialogueEntry(int id, int conversationID, string title)
		{
			return null;
		}

		public List<Field> CreateFields(List<Field> templateFields)
		{
			return null;
		}

		public int GetNextActorID(DialogueDatabase database)
		{
			return 0;
		}

		public int GetNextItemID(DialogueDatabase database)
		{
			return 0;
		}

		public int GetNextQuestID(DialogueDatabase database)
		{
			return 0;
		}

		public int GetNextLocationID(DialogueDatabase database)
		{
			return 0;
		}

		public int GetNextVariableID(DialogueDatabase database)
		{
			return 0;
		}

		public int GetNextConversationID(DialogueDatabase database)
		{
			return 0;
		}

		private int GetNextAssetID<T>(List<T> assets) where T : Asset
		{
			return 0;
		}

		public int GetNextDialogueEntryID(Conversation conversation)
		{
			return 0;
		}
	}
}

using System;
using System.Collections.Generic;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	public class DialogueDatabase : ScriptableObject
	{
		[Serializable]
		public class SyncInfo
		{
			public bool syncActors;

			public bool syncItems;

			public bool syncLocations;

			public bool syncVariables;

			public DialogueDatabase syncActorsDatabase;

			public DialogueDatabase syncItemsDatabase;

			public DialogueDatabase syncLocationsDatabase;

			public DialogueDatabase syncVariablesDatabase;
		}

		public string version;

		public string author;

		public string description;

		public string globalUserScript;

		public const int NumEmphasisSettings = 4;

		public EmphasisSetting[] emphasisSettings;

		public List<Actor> actors;

		public List<Item> items;

		public List<Location> locations;

		public List<Variable> variables;

		public List<Conversation> conversations;

		public SyncInfo syncInfo;

		private Dictionary<string, Actor> actorNameCache;

		private Dictionary<string, Item> itemNameCache;

		private Dictionary<string, Location> locationNameCache;

		private Dictionary<string, Variable> variableNameCache;

		private Dictionary<string, Conversation> conversationTitleCache;

		public const string InvalidEntrytag = "invalid_entrytag";

		public const string VoiceOverFileFieldName = "VoiceOverFile";

		public int playerID => 0;

		public void ResetEmphasisSettings()
		{
		}

		public bool IsPlayerID(int actorID)
		{
			return false;
		}

		public bool IsPlayer(string actorName)
		{
			return false;
		}

		public CharacterType GetCharacterType(int actorID)
		{
			return default(CharacterType);
		}

		private void SetupCaches()
		{
		}

		private Dictionary<string, T> CreateCache<T>(List<T> assets) where T : Asset
		{
			return null;
		}

		public void ResetCache()
		{
		}

		public Actor GetActor(string actorName)
		{
			return null;
		}

		public Actor GetActor(int id)
		{
			return null;
		}

		public Item GetItem(string itemName)
		{
			return null;
		}

		public Item GetItem(int id)
		{
			return null;
		}

		public Location GetLocation(string locationName)
		{
			return null;
		}

		public Location GetLocation(int id)
		{
			return null;
		}

		public Variable GetVariable(string variableName)
		{
			return null;
		}

		public Variable GetVariable(int id)
		{
			return null;
		}

		public void AddConversation(Conversation conversation)
		{
		}

		public Conversation GetConversation(string conversationTitle)
		{
			return null;
		}

		public Conversation GetConversation(int conversationID)
		{
			return null;
		}

		public DialogueEntry GetDialogueEntry(int conversationID, int dialogueEntryID)
		{
			return null;
		}

		public DialogueEntry GetDialogueEntry(Link link)
		{
			return null;
		}

		public string GetLinkText(Link link)
		{
			return null;
		}

		public void Add(DialogueDatabase database)
		{
		}

		private void AddAssets<T>(List<T> myAssets, List<T> assetsToAdd, Dictionary<string, T> cache) where T : Asset
		{
		}

		private void AddEmphasisSettings(EmphasisSetting[] newEmphasisSettings)
		{
		}

		private void AddGlobalUserScript(DialogueDatabase database)
		{
		}

		public void Remove(DialogueDatabase database)
		{
		}

		public void Remove(DialogueDatabase database, List<DialogueDatabase> keep)
		{
		}

		private void RemoveAssets<T>(List<T> myAssets, List<T> assetsToRemove, Dictionary<string, T> cache) where T : Asset
		{
		}

		private void RemoveAssets<T>(List<T> myAssets, List<T> assetsToRemove, Dictionary<string, T> cache, List<DialogueDatabase> keep) where T : Asset
		{
		}

		public void Clear()
		{
		}

		public void SyncAll()
		{
		}

		public void SyncActors()
		{
		}

		public void SyncItems()
		{
		}

		public void SyncLocations()
		{
		}

		public void SyncVariables()
		{
		}

		public static bool ContainsName<T>(List<T> assetList, string assetName) where T : Asset
		{
			return false;
		}

		public static bool ContainsID<T>(List<T> assetList, int assetID) where T : Asset
		{
			return false;
		}

		public static bool ContainsTitle(List<Conversation> conversations, string title)
		{
			return false;
		}

		public static bool Contains(DialogueDatabase database, Asset asset)
		{
			return false;
		}

		public static bool Contains(List<DialogueDatabase> databaseList, Asset asset)
		{
			return false;
		}

		public string GetEntrytag(Conversation conversation, DialogueEntry entry, EntrytagFormat entrytagFormat)
		{
			return null;
		}

		public string GetEntrytag(int conversationID, int dialogueEntryID, EntrytagFormat entrytagFormat)
		{
			return null;
		}

		public string GetEntrytaglocal(Conversation conversation, DialogueEntry entry, EntrytagFormat entrytagFormat)
		{
			return null;
		}

		public string GetEntrytaglocal(int conversationID, int dialogueEntryID, EntrytagFormat entrytagFormat)
		{
			return null;
		}
	}
}

using System.Collections.Generic;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	public class ConversationModel
	{
		private DialogueDatabase m_database;

		private CharacterInfo m_actorInfo;

		private CharacterInfo m_conversantInfo;

		private bool m_allowLuaExceptions;

		private Dictionary<int, CharacterInfo> m_characterInfoCache;

		private EntrytagFormat m_entrytagFormat;

		private EmTag m_emTagForOldResponses;

		private EmTag m_emTagForInvalidResponses;

		private bool m_includeInvalidEntries;

		private string pcPortraitName;

		private Sprite pcPortraitSprite;

		private DialogueEntry forceLinkEntry;

		private int m_currentConversationID;

		public ConversationState firstState { get; private set; }

		public CharacterInfo actorInfo => null;

		public CharacterInfo conversantInfo => null;

		public bool hasValidEntry => false;

		public IsDialogueEntryValidDelegate isDialogueEntryValid { get; set; }

		public ConversationState FirstState
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public CharacterInfo ActorInfo => null;

		public CharacterInfo ConversantInfo => null;

		public bool HasValidEntry => false;

		public IsDialogueEntryValidDelegate IsDialogueEntryValid
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public bool allowLuaExceptions
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public EntrytagFormat entrytagFormat
		{
			get
			{
				return default(EntrytagFormat);
			}
			set
			{
			}
		}

		public EmTag emTagForOldResponses
		{
			get
			{
				return default(EmTag);
			}
			set
			{
			}
		}

		public EmTag emTagForInvalidResponses
		{
			get
			{
				return default(EmTag);
			}
			set
			{
			}
		}

		public bool includeInvalidEntries
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public ConversationModel(DialogueDatabase database, string title, Transform actor, Transform conversant, bool allowLuaExceptions, IsDialogueEntryValidDelegate isDialogueEntryValid, int initialDialogueEntryID = -1, bool stopAtFirstValid = false, bool skipExecution = false)
		{
		}

		public int GetConversationID(ConversationState state)
		{
			return 0;
		}

		public ConversationOverrideDisplaySettings GetConversationOverrideSettings(ConversationState state)
		{
			return null;
		}

		private void FixFirstStateSequence()
		{
		}

		private bool IsStartEntryState(ConversationState state)
		{
			return false;
		}

		public void InformParticipants(string message, bool informDialogueManager = false)
		{
		}

		public ConversationState GetState(DialogueEntry entry, bool includeLinks, bool stopAtFirstValid = false, bool skipExecution = false)
		{
			return null;
		}

		public void ForceNextStateToLinkToEntry(DialogueEntry entry)
		{
		}

		private void AddForcedLink(List<Response> npcResponses, List<Response> pcResponses)
		{
		}

		public ConversationState GetState(DialogueEntry entry)
		{
			return null;
		}

		public void UpdateResponses(ConversationState state)
		{
		}

		private void SetDialogTable(int newConversationID)
		{
		}

		private void CheckSequenceField(DialogueEntry entry)
		{
		}

		private void EvaluateLinks(DialogueEntry entry, List<Response> npcResponses, List<Response> pcResponses, List<DialogueEntry> visited, bool stopAtFirstValid = false)
		{
		}

		private void EvaluateLinksAtPriority(ConditionPriority priority, DialogueEntry entry, List<Response> npcResponses, List<Response> pcResponses, List<DialogueEntry> visited, bool stopAtFirstValid = false)
		{
		}

		private string GetActorName(Actor actor)
		{
			return null;
		}

		private string GetLinkText(CharacterType characterType, DialogueEntry entry)
		{
			return null;
		}

		private void SetParticipants(Conversation conversation, Transform actor, Transform conversant)
		{
		}

		public void UpdateParticipantsOnLinkedConversation(int newConversationID)
		{
		}

		private void IdentifyPCPortrait(Conversation conversation)
		{
		}

		public CharacterInfo GetCharacterInfo(int id, Transform character)
		{
			return null;
		}

		public CharacterInfo GetCharacterInfo(int id)
		{
			return null;
		}

		private Transform GetCharacterTransform(int id)
		{
			return null;
		}

		private Sprite GetPortrait(Transform character, Actor actor)
		{
			return null;
		}

		private Sprite GetPortraitByActorName(string actorName, Actor actor)
		{
			return null;
		}

		public void SetActorPortraitSprite(string actorName, Sprite sprite)
		{
		}

		public string GetPCName()
		{
			return null;
		}

		public Sprite GetPCSprite()
		{
			return null;
		}
	}
}

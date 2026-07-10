using System;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	public class ConversationController
	{
		public delegate void EndConversationDelegate(ConversationController ConversationController);

		private ConversationModel m_model;

		private ConversationView m_view;

		private ConversationState state;

		private EndConversationDelegate m_endConversationHandler;

		private int m_currentConversationID;

		private Response m_currentResponse;

		public bool isActive { get; private set; }

		public CharacterInfo actorInfo => null;

		public ConversationModel conversationModel => null;

		public ConversationView conversationView => null;

		public IsDialogueEntryValidDelegate isDialogueEntryValid
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool randomizeNextEntry { get; set; }

		public CharacterInfo conversantInfo => null;

		public bool IsActive
		{
			get
			{
				return false;
			}
			private set
			{
			}
		}

		public CharacterInfo ActorInfo => null;

		public ConversationModel ConversationModel => null;

		public ConversationView ConversationView => null;

		public IsDialogueEntryValidDelegate IsDialogueEntryValid
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public CharacterInfo ConversantInfo => null;

		public ConversationController(ConversationModel model, ConversationView view, bool alwaysForceResponseMenu, EndConversationDelegate endConversationHandler)
		{
		}

		public void Close()
		{
		}

		public void GotoState(ConversationState state)
		{
		}

		private void AnalyzePCResponses(ConversationState state, out bool isPCResponseMenuNext, out bool isPCAutoResponseNext)
		{
			isPCResponseMenuNext = default(bool);
			isPCAutoResponseNext = default(bool);
		}

		private void SetConversationOverride(ConversationState state)
		{
		}

		public void OnFinishedSubtitle(object sender, EventArgs e)
		{
		}

		public void OnSelectedResponse(object sender, SelectedResponseEventArgs e)
		{
		}

		public void GotoFirstResponse()
		{
		}

		public void GotoLastResponse()
		{
		}

		public void GotoRandomResponse()
		{
		}

		public void GotoCurrentResponse()
		{
		}

		public void SetCurrentResponse(Response response)
		{
		}

		public void UpdateResponses()
		{
		}

		public void SetActorPortraitSprite(string actorName, Sprite sprite)
		{
		}
	}
}

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	public class ConversationView : MonoBehaviour
	{
		private delegate bool IsCancelKeyDownDelegate();

		public static GetDefaultSubtitleDurationDelegate overrideGetDefaultSubtitleDuration;

		private IDialogueUI ui;

		private Sequencer sequencer;

		private DisplaySettings settings;

		private Subtitle lastNPCSubtitle;

		private Subtitle lastPCSubtitle;

		private Subtitle lastSubtitle;

		private IsCancelKeyDownDelegate IsCancelKeyDown;

		private Action CancelledHandler;

		private DialogueEntrySpokenDelegate dialogueEntrySpokenHandler;

		private bool waitForContinue;

		private bool notifyOnFinishSubtitle;

		private bool isPlayingResponseMenuSequence;

		private Subtitle _subtitle;

		private bool _isPCResponseMenuNext;

		private bool _isPCAutoResponseNext;

		private bool _lastModeWasResponseMenu;

		public DisplaySettings displaySettings => null;

		public bool isWaitingForContinue => false;

		public event EventHandler FinishedSubtitleHandler
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event EventHandler<SelectedResponseEventArgs> SelectedResponseHandler
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public void Initialize(IDialogueUI ui, Sequencer sequencer, DisplaySettings displaySettings, DialogueEntrySpokenDelegate dialogueEntrySpokenHandler)
		{
		}

		public void Close()
		{
		}

		private bool Cancelled()
		{
			return false;
		}

		private bool IsSubtitleCancelKeyDown()
		{
			return false;
		}

		private bool IsConversationCancelKeyDown()
		{
			return false;
		}

		public void StartSubtitle(Subtitle subtitle, bool isPCResponseMenuNext, bool isPCAutoResponseNext)
		{
		}

		public void SetupContinueButton()
		{
		}

		private void SetupContinueButton(Subtitle subtitle, bool isPCResponseMenuNext, bool isPCAutoResponseNext)
		{
		}

		private bool ShouldWaitForContinueButton(bool isPCLine, bool isPCResponseMenuNext, bool isPCAutoResponseNext)
		{
			return false;
		}

		private bool ShouldShowContinueButton(bool isPCLine, bool isPCResponseMenuNext, bool isPCAutoResponseNext)
		{
			return false;
		}

		public void ShowLastNPCSubtitle()
		{
		}

		private bool ShouldShowLastNPCSubtitle()
		{
			return false;
		}

		private bool ShouldShowLastPCSubtitle()
		{
			return false;
		}

		private bool ShouldShowSubtitle(Subtitle subtitle)
		{
			return false;
		}

		public void OnConversationContinue(IDialogueUI dialogueUI)
		{
		}

		public void OnConversationContinueAll()
		{
		}

		private void HandleContinueButtonClick()
		{
		}

		private void OnCancelSubtitle()
		{
		}

		private void FinishSubtitle()
		{
		}

		private void OnFinishedSubtitle()
		{
		}

		public void StartResponses(Subtitle subtitle, Response[] responses)
		{
		}

		private void PlayResponseMenuSequence(string responseMenuSequence)
		{
		}

		private void StopResponseMenuSequence()
		{
		}

		private void OnCancelResponseMenu()
		{
		}

		private void OnSelectedResponse(object sender, SelectedResponseEventArgs e)
		{
		}

		public void SelectResponse(SelectedResponseEventArgs e)
		{
		}

		public string GetDefaultSequence(Subtitle subtitle)
		{
			return null;
		}

		public float GetDefaultSubtitleDuration(string text)
		{
			return 0f;
		}

		public static float GetDefaultSubtitleDurationInSeconds(string text, DisplaySettings displaySettings = null)
		{
			return 0f;
		}

		private string PreprocessSequence(Subtitle subtitle)
		{
			return null;
		}

		private void NotifyParticipantsOnConversationLine(Subtitle subtitle)
		{
		}

		private void NotifyParticipantsOnConversationLineEnd(Subtitle subtitle)
		{
		}

		private void NotifyParticipants(string message, Subtitle subtitle)
		{
		}

		private void NotifyOnResponseMenu(Response[] responses)
		{
		}

		private void NotifyParticipantsOnConversationCancelled()
		{
		}

		private bool CharacterInfoHasValidTransform(CharacterInfo characterInfo)
		{
			return false;
		}

		public void SetPCPortrait(Sprite pcSprite, string pcName)
		{
		}

		public void SetActorPortraitSprite(string actorName, Sprite sprite)
		{
		}
	}
}

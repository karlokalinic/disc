using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace PixelCrushers.DialogueSystem
{
	public class StandardUISubtitlePanel : UIPanel
	{
		public RectTransform panel;

		public Image portraitImage;

		public UITextField portraitName;

		public UITextField subtitleText;

		public bool addSpeakerName;

		public string addSpeakerNameFormat;

		public bool accumulateText;

		public bool delayTypewriterUntilOpen;

		public Button continueButton;

		public UIVisibility visibility;

		public string focusAnimationTrigger;

		public string unfocusAnimationTrigger;

		public bool useAnimatedPortraits;

		public bool onlyShowNPCPortraits;

		public UnityEvent onFocus;

		public UnityEvent onUnfocus;

		[SerializeField]
		private bool m_hasFocus;

		private Subtitle m_currentSubtitle;

		private bool m_haveSavedOriginalColor;

		private string m_accumulatedText;

		private Animator m_animator;

		private bool m_isDefaultNPCPanel;

		private bool m_isDefaultPCPanel;

		private int m_panelNumber;

		private Coroutine m_focusWhenOpenCoroutine;

		public bool hasFocus
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public override bool waitForShowAnimation => false;

		public virtual Subtitle currentSubtitle
		{
			get
			{
				return null;
			}
			protected set
			{
			}
		}

		protected bool haveSavedOriginalColor
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		protected Color originalColor { get; set; }

		public string accumulatedText
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private Animator animator => null;

		public bool isDefaultNPCPanel
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool isDefaultPCPanel
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int panelNumber
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public AbstractTypewriterEffect GetTypewriter()
		{
			return null;
		}

		public bool HasTypewriter()
		{
			return false;
		}

		public float GetTypewriterSpeed()
		{
			return 0f;
		}

		public void SetTypewriterSpeed(float charactersPerSecond)
		{
		}

		public virtual void OpenOnStartConversation(Sprite portraitSprite, string portraitName, DialogueActor dialogueActor)
		{
		}

		[Obsolete]
		public virtual void OpenOnStartConversation(Texture2D portraitTexture, string portraitName, DialogueActor dialogueActor)
		{
		}

		public virtual void OnConversationEnd(Transform actor)
		{
		}

		public virtual void ShowSubtitle(Subtitle subtitle)
		{
		}

		public virtual void HideSubtitle(Subtitle subtitle)
		{
		}

		public virtual void HideImmediate()
		{
		}

		protected override void OnHidden()
		{
		}

		public override void Open()
		{
		}

		public override void Close()
		{
		}

		public virtual void Focus()
		{
		}

		protected IEnumerator FocusWhenOpen()
		{
			return null;
		}

		protected virtual void FocusNow()
		{
		}

		private void OnFocused()
		{
		}

		public virtual void Unfocus()
		{
		}

		protected void ActivateUIElements()
		{
		}

		protected void DeactivateUIElements()
		{
		}

		protected virtual void SetUIElementsActive(bool value)
		{
		}

		public virtual void ClearText()
		{
		}

		public virtual void ShowContinueButton()
		{
		}

		public virtual void HideContinueButton()
		{
		}

		public virtual void FinishSubtitle()
		{
		}

		public virtual void Select(bool allowStealFocus = true)
		{
		}

		public virtual void OnContinue()
		{
		}

		public virtual void SetContent(Subtitle subtitle)
		{
		}

		protected virtual IEnumerator StartTypingWhenFocused(UITextField subtitleText, string text, int fromIndex)
		{
			return null;
		}

		protected virtual void SetFormattedText(UITextField textField, string previousText, FormattedText formattedText)
		{
		}

		public virtual void SetActorPortraitSprite(string actorName, Sprite portraitSprite)
		{
		}

		public void CheckSubtitleAnimator(Subtitle subtitle)
		{
		}

		protected void CheckDialogueActorAnimator(DialogueActor dialogueActor)
		{
		}

		private IEnumerator SetAnimatorAtEndOfFrame(RuntimeAnimatorController animatorController)
		{
			return null;
		}
	}
}

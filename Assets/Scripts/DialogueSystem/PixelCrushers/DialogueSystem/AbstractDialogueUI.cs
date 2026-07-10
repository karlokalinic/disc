using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	public abstract class AbstractDialogueUI : MonoBehaviour, IDialogueUI
	{
		private bool m_hasOpenedBefore;

		public abstract AbstractUIRoot uiRootControls { get; }

		public abstract AbstractDialogueUIControls dialogueControls { get; }

		public abstract AbstractUIQTEControls qteControls { get; }

		public abstract AbstractUIAlertControls alertControls { get; }

		public bool isOpen { get; set; }

		public bool IsOpen
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		protected virtual bool AreNonDialogueControlsVisible => false;

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

		public virtual void Awake()
		{
		}

		public virtual void Start()
		{
		}

		public virtual void Open()
		{
		}

		public virtual void Close()
		{
		}

		public virtual void ShowAlert(string message, float duration)
		{
		}

		public virtual void HideAlert()
		{
		}

		public virtual void Update()
		{
		}

		public virtual void ShowSubtitle(Subtitle subtitle)
		{
		}

		public virtual void HideSubtitle(Subtitle subtitle)
		{
		}

		public virtual void ShowContinueButton(Subtitle subtitle)
		{
		}

		public virtual void HideContinueButton(Subtitle subtitle)
		{
		}

		protected virtual void SetSubtitle(Subtitle subtitle, bool value)
		{
		}

		private AbstractUISubtitleControls GetSubtitleControls(Subtitle subtitle)
		{
			return null;
		}

		public virtual void ShowResponses(Subtitle subtitle, Response[] responses, float timeout)
		{
		}

		public virtual void HideResponses()
		{
		}

		public virtual void ShowQTEIndicator(int index)
		{
		}

		public virtual void HideQTEIndicator(int index)
		{
		}

		public virtual void OnClick(object data)
		{
		}

		public virtual void OnContinue()
		{
		}

		public virtual void OnContinueAlert()
		{
		}

		public virtual void OnContinueConversation()
		{
		}

		public virtual void SetPCPortrait(Sprite portraitSprite, string portraitName)
		{
		}

		[Obsolete]
		public virtual void SetPCPortrait(Texture2D portraitTexture, string portraitName)
		{
		}

		public virtual void SetActorPortraitSprite(string actorName, Sprite portraitSprite)
		{
		}

		public static Sprite GetValidPortraitSprite(string actorName, Sprite portraitSprite)
		{
			return null;
		}

		[Obsolete]
		public static Texture2D GetValidPortraitTexture(string actorName, Texture2D portraitTexture)
		{
			return null;
		}
	}
}

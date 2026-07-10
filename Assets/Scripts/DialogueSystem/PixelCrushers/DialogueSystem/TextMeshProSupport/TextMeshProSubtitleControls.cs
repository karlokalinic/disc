using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace PixelCrushers.DialogueSystem.TextMeshProSupport
{
	[Serializable]
	public class TextMeshProSubtitleControls : AbstractUISubtitleControls
	{
		public Graphic panel;

		public TextMeshProUGUI line;

		public Image portraitImage;

		public TextMeshProUGUI portraitName;

		public Button continueButton;

		public bool ignorePauseCodes;

		public UIAnimationTransitions animationTransitions;

		public UIVisibility uiVisibility;

		private UIShowHideController m_showHideController;

		private bool m_haveSavedOriginalColor;

		private Color m_originalColor;

		public bool isVisible => false;

		public override bool hasText => false;

		private UIShowHideController showHideController => null;

		public void CheckSubtitlePortrait(CharacterType characterType)
		{
		}

		private IEnumerator SetSubtitlePortrait(CharacterType characterType)
		{
			return null;
		}

		public override void SetActive(bool value)
		{
		}

		public void ForceHide()
		{
		}

		public void ForceShow()
		{
		}

		private void ShowPanel()
		{
		}

		private void HidePanel()
		{
		}

		public void ActivateUIElements()
		{
		}

		public void DeactivateUIElements()
		{
		}

		private void SetUIElementsActive(bool value)
		{
		}

		public override void ShowContinueButton()
		{
		}

		public override void HideContinueButton()
		{
		}

		public override void SetSubtitle(Subtitle subtitle)
		{
		}

		public override void ClearSubtitle()
		{
		}

		private void SetFormattedText(TextMeshProUGUI label, FormattedText formattedText)
		{
		}

		public override void SetActorPortraitSprite(string actorName, Sprite portraitSprite)
		{
		}

		public void AutoFocus(bool allowStealFocus = true)
		{
		}
	}
}

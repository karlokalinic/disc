using System;
using UnityEngine;

namespace PixelCrushers.DialogueSystem.UnityGUI
{
	[Serializable]
	public class UnitySubtitleControls : AbstractUISubtitleControls
	{
		public GUIControl panel;

		public GUILabel line;

		public GUILabel portraitImage;

		public GUILabel portraitName;

		public GUIButton continueButton;

		public override bool hasText => false;

		public override void SetActive(bool value)
		{
		}

		public override void SetSubtitle(Subtitle subtitle)
		{
		}

		public override void ClearSubtitle()
		{
		}

		public override void ShowContinueButton()
		{
		}

		public override void HideContinueButton()
		{
		}

		public override void SetActorPortraitSprite(string actorName, Sprite portraitSprite)
		{
		}
	}
}

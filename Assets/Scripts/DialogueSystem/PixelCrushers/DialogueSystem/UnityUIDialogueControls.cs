using System;
using UnityEngine.UI;

namespace PixelCrushers.DialogueSystem
{
	[Serializable]
	public class UnityUIDialogueControls : AbstractDialogueUIControls
	{
		public Graphic panel;

		public UIAnimationTransitions animationTransitions;

		public UnityUISubtitleControls npcSubtitle;

		public UnityUISubtitleControls pcSubtitle;

		public UnityUIResponseMenuControls responseMenu;

		private UIShowHideController m_showHideController;

		public override AbstractUISubtitleControls npcSubtitleControls => null;

		public override AbstractUISubtitleControls pcSubtitleControls => null;

		public override AbstractUIResponseMenuControls responseMenuControls => null;

		private UIShowHideController showHideController => null;

		public override void SetActive(bool value)
		{
		}

		public override void ShowPanel()
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
	}
}

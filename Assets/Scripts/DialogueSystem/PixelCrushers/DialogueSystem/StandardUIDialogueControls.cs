using System;

namespace PixelCrushers.DialogueSystem
{
	[Serializable]
	public class StandardUIDialogueControls : AbstractDialogueUIControls
	{
		public UIPanel mainPanel;

		public StandardUISubtitlePanel[] subtitlePanels;

		public StandardUISubtitlePanel defaultNPCSubtitlePanel;

		public StandardUISubtitlePanel defaultPCSubtitlePanel;

		public bool allowOpenSubtitlePanelsOnStartConversation;

		public StandardUIMenuPanel[] menuPanels;

		public StandardUIMenuPanel defaultMenuPanel;

		public bool useFirstResponseForMenuPortrait;

		private StandardUISubtitleControls m_standardSubtitleControls;

		private StandardUIResponseMenuControls m_standardMenuControls;

		private bool m_initializedAnimator;

		public StandardUISubtitleControls standardSubtitleControls => null;

		public override AbstractUISubtitleControls npcSubtitleControls => null;

		public override AbstractUISubtitleControls pcSubtitleControls => null;

		public StandardUIResponseMenuControls standardMenuControls => null;

		public override AbstractUIResponseMenuControls responseMenuControls => null;

		public void Initialize()
		{
		}

		public override void SetActive(bool value)
		{
		}

		public override void ShowPanel()
		{
		}

		private void HidePanel()
		{
		}

		public void HideImmediate()
		{
		}

		private void HideSubtitlePanelsImmediate()
		{
		}

		private void HideMenuPanelsImmediate()
		{
		}

		public void OpenSubtitlePanelsOnStart()
		{
		}
	}
}

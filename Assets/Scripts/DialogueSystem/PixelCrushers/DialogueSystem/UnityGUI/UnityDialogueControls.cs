using System;

namespace PixelCrushers.DialogueSystem.UnityGUI
{
	[Serializable]
	public class UnityDialogueControls : AbstractDialogueUIControls
	{
		public GUIControl panel;

		public UnitySubtitleControls npcSubtitle;

		public UnitySubtitleControls pcSubtitle;

		public UnityResponseMenuControls responseMenu;

		public override AbstractUISubtitleControls npcSubtitleControls => null;

		public override AbstractUISubtitleControls pcSubtitleControls => null;

		public override AbstractUIResponseMenuControls responseMenuControls => null;

		public override void ShowPanel()
		{
		}

		public override void SetActive(bool value)
		{
		}
	}
}

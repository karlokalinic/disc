using System;
using UnityEngine;

namespace PixelCrushers.DialogueSystem.UnityGUI
{
	[Serializable]
	public class UnityResponseMenuControls : AbstractUIResponseMenuControls
	{
		public GUIControl panel;

		public GUILabel pcImage;

		public GUILabel pcName;

		public UnitySubtitleControls subtitleReminder;

		public GUIProgressBar timer;

		public GUIButton[] buttons;

		private TimerEffect timerEffect;

		private Texture2D pcPortraitTexture;

		private string pcPortraitName;

		public override AbstractUISubtitleControls subtitleReminderControls => null;

		public override void SetPCPortrait(Sprite portraitSprite, string portraitName)
		{
		}

		public override void SetActorPortraitSprite(string actorName, Sprite portraitSprite)
		{
		}

		public override void SetActive(bool value)
		{
		}

		protected override void ClearResponseButtons()
		{
		}

		protected override void SetResponseButtons(Response[] responses, Transform target)
		{
		}

		private void SetResponseButton(GUIButton button, Response response, Transform target)
		{
		}

		private int GetNextAvailableResponseButtonPosition(int start, int direction)
		{
			return 0;
		}

		public override void StartTimer(float timeout)
		{
		}

		public void OnTimeout()
		{
		}
	}
}

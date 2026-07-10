using System;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	[Serializable]
	public abstract class AbstractUIResponseMenuControls : AbstractUIControls
	{
		public ResponseButtonAlignment buttonAlignment;

		public bool showUnusedButtons;

		public abstract AbstractUISubtitleControls subtitleReminderControls { get; }

		protected abstract void ClearResponseButtons();

		protected abstract void SetResponseButtons(Response[] responses, Transform target);

		public abstract void StartTimer(float timeout);

		public virtual void ShowResponses(Subtitle subtitle, Response[] responses, Transform target)
		{
		}

		public virtual void SetPCPortrait(Sprite sprite, string portraitName)
		{
		}

		[Obsolete]
		public virtual void SetPCPortrait(Texture2D texture, string portraitName)
		{
		}

		public virtual void SetActorPortraitSprite(string actorName, Sprite sprite)
		{
		}

		[Obsolete]
		public virtual void SetActorPortraitTexture(string actorName, Texture2D texture)
		{
		}
	}
}

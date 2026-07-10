using System;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	[Serializable]
	public abstract class AbstractUISubtitleControls : AbstractUIControls
	{
		protected Subtitle currentSubtitle;

		public abstract bool hasText { get; }

		public bool HasText => false;

		public abstract void SetSubtitle(Subtitle subtitle);

		public abstract void ClearSubtitle();

		public virtual void ShowContinueButton()
		{
		}

		public virtual void HideContinueButton()
		{
		}

		public virtual void ShowSubtitle(Subtitle subtitle)
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

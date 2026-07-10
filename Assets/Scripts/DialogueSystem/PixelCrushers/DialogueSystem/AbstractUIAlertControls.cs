using System;

namespace PixelCrushers.DialogueSystem
{
	[Serializable]
	public abstract class AbstractUIAlertControls : AbstractUIControls
	{
		protected float m_alertDoneTime;

		public abstract bool isVisible { get; }

		public virtual bool isDone => false;

		public bool IsVisible => false;

		public bool IsDone => false;

		public abstract void SetMessage(string message, float duration);

		public virtual void ShowMessage(string message, float duration)
		{
		}
	}
}

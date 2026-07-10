using System;

namespace PixelCrushers.DialogueSystem
{
	[Serializable]
	public abstract class AbstractUIControls
	{
		public abstract void SetActive(bool value);

		public void Show()
		{
		}

		public void Hide()
		{
		}
	}
}

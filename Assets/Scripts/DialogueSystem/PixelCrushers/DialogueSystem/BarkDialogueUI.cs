using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	public class BarkDialogueUI : MonoBehaviour, IDialogueUI
	{
		public event EventHandler<SelectedResponseEventArgs> SelectedResponseHandler
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public void Open()
		{
		}

		public void Close()
		{
		}

		public void ShowSubtitle(Subtitle subtitle)
		{
		}

		public void HideSubtitle(Subtitle subtitle)
		{
		}

		public void ShowResponses(Subtitle subtitle, Response[] responses, float timeout)
		{
		}

		public void HideResponses()
		{
		}

		public void ShowQTEIndicator(int index)
		{
		}

		public void HideQTEIndicator(int index)
		{
		}

		public void ShowAlert(string message, float duration)
		{
		}

		public void HideAlert()
		{
		}
	}
}

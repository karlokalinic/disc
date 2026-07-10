using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace PixelCrushers.DialogueSystem.UnityGUI
{
	public class TimerEffect : GUIEffect
	{
		public float duration;

		private GUIProgressBar progressBar;

		public event Action TimeoutHandler
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

		public override IEnumerator Play()
		{
			return null;
		}
	}
}

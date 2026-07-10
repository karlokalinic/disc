using System.Collections;

namespace PixelCrushers.DialogueSystem.UnityGUI
{
	public class FadeEffect : GUIEffect
	{
		public float fadeInDuration;

		public float duration;

		public float fadeOutDuration;

		private GUIVisibleControl control;

		public void SetFadeDurations(float fadeInDuration, float duration, float fadeOutDuration)
		{
		}

		public override IEnumerator Play()
		{
			return null;
		}
	}
}

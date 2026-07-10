using UnityEngine;

namespace Voidforge
{
	public class TweenHue : TweenAlpha
	{
		public AnimationCurve hue;

		protected override float duration => 0f;

		protected override Color GetColor(Color normalColor)
		{
			return default(Color);
		}
	}
}

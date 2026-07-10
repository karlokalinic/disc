using UnityEngine;
using UnityEngine.UI;

namespace Voidforge
{
	public class TweenAlpha : Tween
	{
		public AnimationCurve alpha;

		[GetComponent]
		protected ComponentRef<Renderer> renderers;

		[GetComponent]
		protected ComponentRef<Graphic> graphics;

		protected virtual float duration => 0f;

		protected virtual Color GetColor(Color normalColor)
		{
			return default(Color);
		}

		protected override void Repaint()
		{
		}
	}
}

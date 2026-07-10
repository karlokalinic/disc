using UnityEngine;

namespace Voidforge
{
	public class UITweenCanvasgroupAlpha : Tween
	{
		public AnimationCurve alpha;

		protected ComponentRef<CanvasGroup> canvasGroup;

		protected float duration => 0f;

		protected override void Repaint()
		{
		}
	}
}

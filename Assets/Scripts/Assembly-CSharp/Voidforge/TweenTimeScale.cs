using UnityEngine;

namespace Voidforge
{
	public class TweenTimeScale : TweenValue<float>
	{
		public AnimationCurve timeScale;

		public override float Item => 0f;

		protected float duration => 0f;

		protected override void Repaint()
		{
		}
	}
}

using UnityEngine;

namespace Voidforge
{
	public class TweenAnimation : Tween, Tween.IBeforePlaying
	{
		public AnimationClip tweenAnimationClip;

		public string clipName;

		[GetComponent]
		private ComponentRef<Animation> _animation;

		private AnimationState animationState;

		protected float duration => 0f;

		void IBeforePlaying.BeforePlaying()
		{
		}

		protected override void Repaint()
		{
		}
	}
}

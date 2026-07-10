using UnityEngine;

namespace Voidforge
{
	public class TweenAudioSourceVolume : TweenValue<float>
	{
		public AnimationCurve volumeCurve;

		[GetComponent]
		private ComponentRef<AudioSource> _audioSource;

		public override float Item => 0f;

		protected float duration => 0f;

		protected override void Repaint()
		{
		}
	}
}

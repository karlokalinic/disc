using UnityEngine;
using Voidforge;

namespace Sunshine
{
	public class TweenMasterAudioPlaylistVolume : TweenValue<float>
	{
		public AnimationCurve volumeCurve;

		public override float Item => 0f;

		protected float duration => 0f;

		protected override void Repaint()
		{
		}
	}
}

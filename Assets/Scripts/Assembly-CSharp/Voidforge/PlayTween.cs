using UnityEngine;

namespace Voidforge
{
	public class PlayTween : CustomYieldInstruction
	{
		protected Tween _tween;

		public override bool keepWaiting => false;

		public PlayTween(Tween tween)
		{
		}
	}
}

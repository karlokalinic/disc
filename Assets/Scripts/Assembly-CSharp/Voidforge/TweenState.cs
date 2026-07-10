using System;

namespace Voidforge
{
	[Flags]
	public enum TweenState : byte
	{
		None = 0,
		IsPlaying = 1,
		IsTweening = 2,
		StartedTweening = 4,
		FinishedTweening = 8
	}
}

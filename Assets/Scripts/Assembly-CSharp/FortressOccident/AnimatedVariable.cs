using System;
using UnityEngine;

namespace FortressOccident
{
	[Serializable]
	public struct AnimatedVariable
	{
		public float amount;

		public bool overrideAnimation;

		public bool modifiedByHeartbeat;

		public AnimationCurve animation;

		public float Eval(float eval, bool isTimeFreeze = false)
		{
			return 0f;
		}
	}
}

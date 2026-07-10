using System;
using UnityEngine;

namespace Voidforge
{
	[Serializable]
	public class ObservedAnimationCurve : ObservedValue<AnimationCurve>
	{
		public ObservedAnimationCurve()
		{
		}

		public ObservedAnimationCurve(AnimationCurve curveValue, Operation operations = Operation.AllChanges, string fullName = null)
		{
		}
	}
}

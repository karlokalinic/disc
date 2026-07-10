using UnityEngine;

namespace Sunshine.Unseen
{
	public abstract class StatusCurve : MonoBehaviour
	{
		public abstract AnimationCurve curve { get; }

		public abstract float defaultDuration { get; }

		public static float Evaluate(StatusCurve statusCurve, float t)
		{
			return 0f;
		}
	}
}

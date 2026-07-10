using UnityEngine;

namespace Sunshine.Unseen
{
	public class InactiveCurve : StatusCurve
	{
		private const float _defaultDuration = 30f;

		[SerializeField]
		protected AnimationCurve _curve;

		public override AnimationCurve curve => null;

		public override float defaultDuration => 0f;
	}
}

using UnityEngine;

namespace Sunshine.Unseen
{
	public class ActiveCurve : StatusCurve
	{
		private const float _defaultDuration = 0.3f;

		[SerializeField]
		protected AnimationCurve _curve;

		public override AnimationCurve curve => null;

		public override float defaultDuration => 0f;
	}
}

using UnityEngine;

namespace RootMotion.FinalIK
{
	public class RotationLimitSpline : RotationLimit
	{
		public float twistLimit;

		[HideInInspector]
		[SerializeField]
		public AnimationCurve spline;

		private void OpenUserManual()
		{
		}

		private void OpenScriptReference()
		{
		}

		private void SupportGroup()
		{
		}

		private void ASThread()
		{
		}

		public void SetSpline(Keyframe[] keyframes)
		{
		}

		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		public Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}
	}
}

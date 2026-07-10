using UnityEngine;

namespace RootMotion.FinalIK
{
	public class TwistRelaxer : MonoBehaviour
	{
		public float weight;

		public float parentChildCrossfade;

		private Vector3 twistAxis;

		private Vector3 axis;

		private Vector3 axisRelativeToParentDefault;

		private Vector3 axisRelativeToChildDefault;

		private Transform parent;

		private Transform child;

		public void Relax()
		{
		}

		private void Start()
		{
		}

		private void LateUpdate()
		{
		}
	}
}

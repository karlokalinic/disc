using UnityEngine;

namespace CollageMode
{
	public class DistanceUnlocker : MonoBehaviour
	{
		[SerializeField]
		private float distanceToUnlock;

		[SerializeField]
		private float maxFadeOutDistance;

		private FadeController fadeController;

		private void Awake()
		{
		}

		public void CalculateDistance()
		{
		}

		public bool CheckCondition()
		{
			return false;
		}

		private float DistanceToCamera()
		{
			return 0f;
		}

		private void OnDrawGizmosSelected()
		{
		}
	}
}

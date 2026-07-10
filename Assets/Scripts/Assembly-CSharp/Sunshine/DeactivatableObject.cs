using UnityEngine;

namespace Sunshine
{
	public class DeactivatableObject : MonoBehaviour
	{
		private bool areastateVisible;

		private bool schedulerVisible;

		private bool developerVisible;

		public void SetAreaStateVisible(bool isVisible)
		{
		}

		public void SetSchedulerVisible(bool isVisible)
		{
		}

		public void SetDeveloperVisible(bool isVisible)
		{
		}

		private bool IsVisibleByState()
		{
			return false;
		}

		private void OnEnable()
		{
		}

		public static void Consider(DeactivatableObject x)
		{
		}
	}
}

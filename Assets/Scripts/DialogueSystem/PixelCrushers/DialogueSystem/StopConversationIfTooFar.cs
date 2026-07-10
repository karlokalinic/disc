using System.Collections;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	public class StopConversationIfTooFar : MonoBehaviour
	{
		public float maxDistance;

		public float monitorFrequency;

		private void OnConversationStart(Transform actor)
		{
		}

		private void OnConversationEnd(Transform actor)
		{
		}

		private void OnDisable()
		{
		}

		private IEnumerator MonitorDistance(Transform actor)
		{
			return null;
		}
	}
}

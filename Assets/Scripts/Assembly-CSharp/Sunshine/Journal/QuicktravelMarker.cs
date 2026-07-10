using UnityEngine;

namespace Sunshine.Journal
{
	public class QuicktravelMarker : MonoBehaviour
	{
		[HideInInspector]
		public bool wasVisited;

		[HideInInspector]
		public string locationMarkerTag;

		public float activationRadius;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		public bool CheckTequilaInActivationRadius()
		{
			return false;
		}
	}
}

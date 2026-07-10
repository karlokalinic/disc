using UnityEngine;

namespace MultiplayerWithBindingsExample
{
	public class Player : MonoBehaviour
	{
		private Renderer cachedRenderer;

		public PlayerActions Actions { get; set; }

		private void OnDisable()
		{
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		private Color GetColorFromInput()
		{
			return default(Color);
		}
	}
}

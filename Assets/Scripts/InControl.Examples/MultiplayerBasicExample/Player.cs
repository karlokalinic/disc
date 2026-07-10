using InControl;
using UnityEngine;

namespace MultiplayerBasicExample
{
	public class Player : MonoBehaviour
	{
		private Renderer cachedRenderer;

		public InputDevice Device { get; set; }

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

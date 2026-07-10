using UnityEngine;
using UnityEngine.UI;

namespace TwitchIntegration.UI
{
	public class TwitchActiveStatus : MonoBehaviour
	{
		[SerializeField]
		private Image image;

		[SerializeField]
		private Color activeTwitch;

		[SerializeField]
		private Color inactiveColor;

		private void OnEnable()
		{
		}

		private void RefreshColor(bool value = false)
		{
		}

		private Color GetColorForTwitchIntegrationState()
		{
			return default(Color);
		}
	}
}

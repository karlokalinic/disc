using UnityEngine;
using UnityEngine.UI;

namespace TwitchIntegration.Debug
{
	public abstract class TwitchDebug : MonoBehaviour
	{
		[SerializeField]
		protected CanvasGroup canvasGroup;

		[SerializeField]
		protected Text resultLabel;

		protected virtual void Reset()
		{
		}

		protected virtual void Awake()
		{
		}
	}
}

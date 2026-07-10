using System.Collections;
using TMPro;
using UnityEngine;

namespace DiscoPages.Elements.Common
{
	public class InPageMessage : MonoBehaviour
	{
		[SerializeField]
		private CanvasGroup canvasGroup;

		[SerializeField]
		private TextMeshProUGUI contentMessage;

		[SerializeField]
		private float showHideDuration;

		[SerializeField]
		private float duration;

		private bool isShowing;

		private bool isHiding;

		private Coroutine showHide;

		private float timeToHide;

		private void Update()
		{
		}

		public void Show(Vector3 postion, string message)
		{
		}

		public void Hide()
		{
		}

		public void ForceHide()
		{
		}

		private IEnumerator ShowCo()
		{
			return null;
		}

		private IEnumerator HideCo()
		{
			return null;
		}
	}
}

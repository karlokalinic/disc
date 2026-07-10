using UnityEngine;
using UnityEngine.UI;

namespace Coffee.UISoftMask.Demos
{
	public class SoftMask_Demo : MonoBehaviour
	{
		[SerializeField]
		private RawImage[] softMaskBufferViewer;

		[SerializeField]
		private SoftMask[] softMask;

		[SerializeField]
		private Text text;

		[SerializeField]
		private GameObject title;

		private void OnEnable()
		{
		}

		public void SetWorldSpase(bool flag)
		{
		}

		public void SetScreenSpase(bool flag)
		{
		}

		public void SetOverlay(bool flag)
		{
		}
	}
}

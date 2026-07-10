using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace PixelCrushers
{
	public class UIScrollbarEnabler : MonoBehaviour
	{
		public ScrollRect scrollRect;

		public RectTransform scrollContent;

		public Scrollbar scrollbar;

		private bool m_started;

		private bool m_checking;

		private void Start()
		{
		}

		public void OnEnable()
		{
		}

		public void OnDisable()
		{
		}

		public void CheckScrollbar()
		{
		}

		public void CheckScrollbarWithResetValue(float value)
		{
		}

		private IEnumerator CheckScrollbarAfterUIUpdate(bool useResetValue, float resetValue)
		{
			return null;
		}
	}
}

using UnityEngine;
using UnityEngine.UI;

namespace PixelCrushers
{
	public class UIButtonKeyTrigger : MonoBehaviour
	{
		public KeyCode key;

		public string buttonName;

		private Selectable m_selectable;

		private void Awake()
		{
		}

		private void Update()
		{
		}

		protected virtual void OnInputKey()
		{
		}
	}
}

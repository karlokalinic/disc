using UnityEngine;
using UnityEngine.UI;

namespace CollageMode
{
	public class ToggleChangeColor : MonoBehaviour
	{
		private Toggle toggle;

		[SerializeField]
		private Graphic graphic;

		[SerializeField]
		private Color colorOn;

		[SerializeField]
		private Color colorOff;

		private bool value;

		private void Awake()
		{
		}

		private void Update()
		{
		}

		private void Refresh()
		{
		}
	}
}

using UnityEngine;
using UnityEngine.UI;

namespace CollageMode
{
	public class ToggleChangeSprite : MonoBehaviour
	{
		private Toggle toggle;

		[SerializeField]
		private Image image;

		[SerializeField]
		private Sprite spriteOn;

		[SerializeField]
		private Sprite spriteOff;

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

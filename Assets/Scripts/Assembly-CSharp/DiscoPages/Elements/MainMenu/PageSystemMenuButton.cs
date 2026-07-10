using I2.Loc;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace DiscoPages.Elements.MainMenu
{
	public class PageSystemMenuButton : MonoBehaviour
	{
		[SerializeField]
		private Button button;

		[SerializeField]
		private TextMeshProUGUI text;

		[SerializeField]
		private Localize localization;

		private void Reset()
		{
		}

		public void SetButton(string label, string localizationTag, UnityAction onClick)
		{
		}
	}
}

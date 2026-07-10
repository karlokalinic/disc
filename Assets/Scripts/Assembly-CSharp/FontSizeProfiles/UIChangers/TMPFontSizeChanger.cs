using TMPro;
using UnityEngine;

namespace FontSizeProfiles.UIChangers
{
	public class TMPFontSizeChanger : TMPChanger
	{
		[SerializeField]
		private TextMeshProUGUI textElement;

		private void Reset()
		{
		}

		private void Awake()
		{
		}

		protected override void OnLayoutChanged()
		{
		}

		private void OnLanguageChanged()
		{
		}
	}
}

using UnityEngine;
using UnityEngine.UI;

namespace FontSizeProfiles.UIChangers
{
	public class TextFontSizeChanger : TMPChanger
	{
		[SerializeField]
		private Text textElement;

		private void Reset()
		{
		}

		private void Awake()
		{
		}

		protected override void OnLayoutChanged()
		{
		}
	}
}

using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace LocalizationCustomSystem
{
	public class LocalizeFontSizeTMPro : MonoBehaviour
	{
		[SerializeField]
		private TranslationFontSize[] translationList;

		private Dictionary<string, int> fontSizeDict;

		private TextMeshProUGUI text;

		private bool isInitialized;

		private static string DefaultLanguageCode => null;

		private void Awake()
		{
		}

		private void Initialize()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void UpdateTextSize()
		{
		}
	}
}

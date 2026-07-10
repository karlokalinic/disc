using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace LocalizationCustomSystem
{
	public class LocalizedShadows : MonoBehaviour
	{
		[SerializeField]
		private TranslationShadows[] translationList;

		private Dictionary<string, TranslationShadows> fontSizeDict;

		private Text text;

		private TextMeshProUGUI textMeshProText;

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

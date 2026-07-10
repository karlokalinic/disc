using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace LocalizationCustomSystem
{
	public class LocalizeTextOffset : MonoBehaviour
	{
		[SerializeField]
		private TranslationTextOffset[] translationList;

		private Dictionary<string, TranslationTextOffset> textOffsetDict;

		private Text text;

		private TextMeshProUGUI textMeshProText;

		private bool isInitialized;

		private bool wasFirstTimeUpdated;

		private string previousLanguageCode;

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

		public void UpdateTextOffset()
		{
		}
	}
}

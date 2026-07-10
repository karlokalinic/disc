using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace LocalizationCustomSystem
{
	public class LocalizeFontSize : MonoBehaviour
	{
		[SerializeField]
		private TranslationFontSize[] translationList;

		private Dictionary<string, int> fontSizeDict;

		private Text text;

		private TextMeshProUGUI textMeshProText;

		private static string DefaultLanguageCode => null;

		public bool IsInitialized { get; private set; }

		public event Action OnInitialize
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

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

		public float GetLocalizedFontSize()
		{
			return 0f;
		}
	}
}

using System.Collections.Generic;
using UnityEngine;

namespace LocalizationCustomSystem
{
	public class LocalizeRectTransformOffset : MonoBehaviour
	{
		[SerializeField]
		private TranslationTextOffset[] translationList;

		private Dictionary<string, TranslationTextOffset> rectOffsetDict;

		private RectTransform rectTransform;

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

		public void UpdateRectOffset()
		{
		}
	}
}

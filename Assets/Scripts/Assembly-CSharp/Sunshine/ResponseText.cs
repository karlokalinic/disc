using System.Collections;
using FortressOccident;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Sunshine
{
	public class ResponseText : FOComponent
	{
		private const float TREMENDOUS_WIDTH = 60f;

		private const float HUMUNGOUS_WIDTH = 60f;

		private const float LARGE_WIDTH = 44f;

		private const float NORMAL_WIDTH = 30f;

		[SerializeField]
		private TextMeshProUGUI textField;

		[SerializeField]
		private TextMeshProUGUI numberField;

		private string originalText;

		private RectTransform rectTransform;

		private LayoutElement textLayoutElement;

		private LayoutElement numberLayoutElement;

		private LayoutElement parentLayoutElement;

		private bool isInitialized;

		private IEnumerator delayedUpdateHeightCoR;

		public TextMeshProUGUI TextField => null;

		public TextMeshProUGUI NumberText => null;

		private new void Awake()
		{
		}

		public void OnDestroy()
		{
		}

		private void Start()
		{
		}

		public void UpdateText(bool isLocalizationCallback)
		{
		}

		public void OnResolutionChanged(ResolutionSetting resolution)
		{
		}

		private void OnTextSizeChanged(TextSizeConfiguration.TextSize textSize)
		{
		}

		public void UpdateTextSizeCallback(TextSizeConfiguration.TextSize textSize, bool firstUpdate, int waitFrames = 3)
		{
		}

		private void UpdateTextSize(TextSizeConfiguration.TextSize textSize)
		{
		}

		private IEnumerator UpdateLayoutHeightDelayed(int waitFrames)
		{
			return null;
		}

		private void UpdateLayoutElementHeight()
		{
		}
	}
}

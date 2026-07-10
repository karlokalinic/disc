using TMPro;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.UI;

namespace Sunshine
{
	public class BuyOptionTooltip : Tooltip<BuyOptionTooltip>
	{
		public HorizontalLayoutGroup contentLayoutGroup;

		public CanvasGroup canvasGroup;

		public TextMeshProUGUI titleText;

		public TextMeshProUGUI effectsText;

		public Image portraitImg;

		private string prevItemName;

		private AsyncOperationHandle<Sprite> spriteHandle;

		private bool firstLineFlag;

		private bool isAsyncPrepared;

		private string NewLine => null;

		public override void SetTooltipContent(TooltipSource tooltipSource)
		{
		}

		protected override void Awake()
		{
		}

		private void OnDisable()
		{
		}

		private void LoadItemImageAsync(string itemName)
		{
		}

		private void UnloadItemImageAsync()
		{
		}

		private void SetItemImage(AsyncOperationHandle<Sprite> itemImageHandle)
		{
		}
	}
}

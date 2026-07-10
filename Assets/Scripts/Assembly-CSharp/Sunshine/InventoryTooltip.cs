using System.Collections;
using Sunshine.Metric;
using TMPro;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.UI;
using Voidforge;

namespace Sunshine
{
	public class InventoryTooltip : SingletonComponent<InventoryTooltip>
	{
		[SerializeField]
		private Scrollbar descriptionScrollbar;

		public Image bigItemImage;

		public Image bigItemImageGlow;

		public Image bigItemImageGhostFrame;

		public InventoryTutorial inventoryTutorial;

		public GameObject titlePanel;

		public TextMeshProUGUI title;

		public TextMeshProUGUI subtitle;

		public TextMeshProUGUI description;

		public TextMeshProUGUI properties;

		public TextMeshProUGUI price;

		private string conversation;

		public bool introductionShown;

		public GameObject pawnshopPanel;

		public Button interactButton;

		public TextMeshProUGUI interactButtonText;

		public Button closeButton;

		[SerializeField]
		private Button additionalInteractButton;

		[SerializeField]
		private TextMeshProUGUI additionalInteractButtonText;

		private static InventoryItem selectedItem;

		private static UIDraggable selectedDraggable;

		private bool firstLineFlag;

		private int lastPawnableItemIndex;

		private string propertiesText;

		private bool isAsyncPrepared;

		private string prevItemName;

		private AsyncOperationHandle<Sprite> spriteHandle;

		protected string _source;

		protected ComponentRef<RectTransform> rt;

		protected Timer delayTimer;

		public static InventoryItem SelectedItem => null;

		private string NewLine => null;

		public string Source
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Update()
		{
		}

		private void OnLanguageChanged()
		{
		}

		public static void ShowAndGlow(UIDraggable target)
		{
		}

		public static void Show(string source)
		{
		}

		public static bool IsShowingItem(UIDraggable target)
		{
			return false;
		}

		public void ShowIntroduction()
		{
		}

		public void ShowPawnableView(bool selectFirstItem = false)
		{
		}

		public void HidePawnableView()
		{
		}

		public void ClosePawnableView()
		{
		}

		private void ToggleTextVisibility(bool isActive)
		{
		}

		public void CloseInventoryView()
		{
		}

		public void Hide()
		{
		}

		private void UpdateLastPawnableItemIndex(string itemName)
		{
		}

		public void SetSource(string source)
		{
		}

		protected void UseSource(string subjectName)
		{
		}

		private IEnumerator ResetScroll()
		{
			return null;
		}

		private void PrimeItem(InventoryItem item)
		{
		}

		private void LoadSpriteAsync(InventoryItem item)
		{
		}

		private void SetPortrait(AsyncOperationHandle<Sprite> itemIconHandle)
		{
		}

		private void UnloadPortraitAsync()
		{
		}

		private void SetSubtitleText(InventoryItem item)
		{
		}

		private string PreparePropertyRichText(CharacterEffect effect)
		{
			return null;
		}

		private void PrimeConversation()
		{
		}

		private void PrimeSubstance(InventoryItem item)
		{
		}

		private void PrimePawnable(InventoryItem item, string itemName)
		{
		}

		private void PrimePawnableInShop(InventoryItem item, string itemName)
		{
		}

		public void DelayedUpdateAndShowPawnable(bool selectFirstItem = false)
		{
		}

		private IEnumerator ShowPawnableCOR(bool selectFirstItem)
		{
			return null;
		}

		private bool TryPrimeNextPawnableItem()
		{
			return false;
		}

		public void SellAllPawnables()
		{
		}

		private void CheckForAlterations(InventoryItem item)
		{
		}

		private string ConvertToColoredRichText(string text, Color color)
		{
			return null;
		}

		internal static Button GetSelectableButton()
		{
			return null;
		}

		private void SetPawnColorButton()
		{
		}

		private void SetInteractColorButton()
		{
		}
	}
}

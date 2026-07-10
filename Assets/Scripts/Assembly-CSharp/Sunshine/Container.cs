using System.Collections.Generic;
using Sunshine.Views;
using UnityEngine;
using UnityEngine.UI;
using Voidforge;

namespace Sunshine
{
	public class Container : SingletonComponent<Container>
	{
		public bool followMouseCursor;

		public CanvasGroup canvasGroup;

		public GameObject moneyAmountPanelTemplate;

		public Button itemTemplate;

		[Space]
		public Button takeAllButton;

		public Button closeButton;

		public int columns;

		public int loadedImagesCounter;

		public float gridSpacing;

		private Camera mainCamera;

		private const string MONEY_NAME = "money";

		public List<RectTransform> ContainerList;

		[SerializeField]
		private RectTransform leftSlot;

		[SerializeField]
		private RectTransform rightSlot;

		private Button[] containerButtonsItems;

		private GameObject[] moneyAmountPanels;

		private GenericObjectPool<Button> itemsButtonsPool;

		private GenericObjectPool<GameObject> moneyAmountPanelsPool;

		private ContainerSource _source;

		protected ComponentRef<RectTransform> rt;

		private Timer delayTimer;

		public Vector3 Position
		{
			set
			{
			}
		}

		public ContainerSource Source
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private Vector3 MouseCursorPosition => default(Vector3);

		protected override void Awake()
		{
		}

		private Button CreateItemButton()
		{
			return null;
		}

		private GameObject CreateMoneyAmountPanel()
		{
			return null;
		}

		private void OnItemButtonReleasedToPool(Button itemButton)
		{
		}

		private void OnMoneyPanelReleasedToPool(GameObject moneAmountPanel)
		{
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void OnDisable()
		{
		}

		public static void Show(ContainerSource source)
		{
		}

		public static void Hide()
		{
		}

		public static void Hide(ContainerSource source)
		{
		}

		public static bool IsActive()
		{
			return false;
		}

		public void OnCloseButton()
		{
		}

		private static void HideCurrentContainerSource(ViewType nextView)
		{
		}

		public void DetachTemplates()
		{
		}

		private void ClearItemButtons()
		{
		}

		private void LateUpdate()
		{
		}

		private void SetSource(ContainerSource source)
		{
		}

		private void HideOrDestroyContainer(GameObject container)
		{
		}

		private void SetItems()
		{
		}

		private void OnGridImageLoaded()
		{
		}

		private void TakeItemFromContainer(ContainerItem item, RectTransform containerItem)
		{
		}

		private void setSelectable()
		{
		}

		private int GetItemValueWithDeviation(int value, int deviation)
		{
			return 0;
		}

		protected override void OnDestroy()
		{
		}
	}
}

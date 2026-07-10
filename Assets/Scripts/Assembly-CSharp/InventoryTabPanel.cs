using System.Collections;
using System.Collections.Generic;
using LocalizationCustomSystem;
using UnityEngine;
using UnityEngine.UI;

public class InventoryTabPanel : TabPanel<ItemTabGroup>
{
	[SerializeField]
	private Selectable upSelectable;

	[SerializeField]
	private Selectable downSelectable;

	[SerializeField]
	private Selectable leftSelectable;

	[SerializeField]
	private Selectable rightSelectable;

	[SerializeField]
	private RectTransform changeTabPromptL;

	[SerializeField]
	private RectTransform changeTabPromptR;

	public static InventoryTabPanel Singleton;

	public InventoryTabButton tabButtonTemplate;

	public Transform tabButtonParent;

	public TweenRectTransform ActiveBackground;

	public TranslationString toolsTabHeaderTerm;

	public TranslationString clothesTabHeaderTerm;

	public TranslationString itemsTabHeaderTerm;

	public TranslationString interactTabHeaderTerm;

	public VerticalStepScrollView verticalStepScrollView;

	private const float InitializationDelay = 0.1f;

	private ItemTabGroup currentItemTabGroup;

	public InventoryTabButton FirstTabButton => null;

	public Dictionary<ItemTabGroup, InventoryTabButton> inventoryTabButtons { get; private set; }

	public ItemTabGroup CurrentItemTabGroup => default(ItemTabGroup);

	public void Awake()
	{
	}

	private void UpdateActiveTweenBackground()
	{
	}

	private IEnumerator DelayedTweenBackgroundUpdate()
	{
		return null;
	}

	public override void ActivatePanel(ItemTabGroup tabGroup, bool initializing = false)
	{
	}

	public override void UpdateScrollViewSize()
	{
	}

	private void InitializeTabsForView()
	{
	}

	private IEnumerator DelayedTabsUpdate(float delay, bool initializing, ItemTabGroup tabGroup)
	{
		return null;
	}

	private void InstantiateTabButton(ItemTabGroup tabButtonType, string term)
	{
	}

	public override void ToggleFreshNotifier(ItemTabGroup tabGroup, bool isActive)
	{
	}
}

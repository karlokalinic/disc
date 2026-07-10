using Sunshine.Metric;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class HudHeldButton : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	[SerializeField]
	private GameObject heldItemTooltipSource;

	[SerializeField]
	private Image heldItemIcon;

	[SerializeField]
	private Image itemsCountPanel;

	[SerializeField]
	private TextMeshProUGUI itemsCountText;

	private Color DisabledColor;

	private Color DisabledHighLightedColor;

	private Color NormalColor;

	private Color NormalColorFrame;

	private Color NormalHighlightedColor;

	private Button button;

	private Image buttonTargetImage;

	private int itemsCount;

	private InventoryItem heldItem;

	private bool isMouseOver;

	private float whenMouseChangedState;

	private const float TIME_FOR_INACTIVE_COLOR_FADE = 0.1f;

	private HudHeldPanelController.Hand Hand { get; set; }

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void SetHandForButton(HudHeldPanelController.Hand left)
	{
	}

	public void UpdateUsesAmount(int uses)
	{
	}

	public void UpdateButton(InventoryItem heldItem, bool interactable, string itemName, Sprite itemIcon, int itemsCount, Color buttonColor, Color iconColor, Color disabledColor, Color DisabledHighLightColor, Color NormalHightlightColor, Color buttonColorFrame)
	{
	}

	public void SetInteractability(bool interactable, Color iconColor)
	{
	}

	public void OnHeldButtonClicked()
	{
	}

	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	public void OnPointerExit(PointerEventData eventData)
	{
	}

	private void AbuseHeldSubstance()
	{
	}
}

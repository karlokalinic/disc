using System.Collections;
using Sunshine.Metric;
using UnityEngine;

public class HudHeldPanelController : HudElementController
{
	public enum Hand
	{
		left = 0,
		right = 1,
		none = 2
	}

	[Space]
	public bool SpecialHeldButtonActive;

	[SerializeField]
	[Space]
	private Color defaultButtonFrameColor;

	[SerializeField]
	private Color activeIconColor;

	[SerializeField]
	private Color activeHighLightIconColor;

	[SerializeField]
	private Color inactiveIconColor;

	[SerializeField]
	private Color inactiveHighLightIconColor;

	[SerializeField]
	private HudHeldButton specialHeldButton;

	[SerializeField]
	private HudHeldButton leftHandHeldButton;

	[SerializeField]
	private HudHeldButton rightHandHeldButton;

	[SerializeField]
	[Space]
	private Sprite leftHandDefaultIcon;

	[SerializeField]
	private Sprite rightHandDefaultIcon;

	private bool isDisabled;

	private static readonly int left;

	private static readonly int right;

	private static readonly int interrupt;

	public const int substantialSubstanceUse = 3;

	public const int substanceTime = 60;

	public static HudHeldPanelController Current { get; protected set; }

	public override void Awake()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void UpdateHeldPanel()
	{
	}

	public void DisableHeldPanelButtons()
	{
	}

	public void EnableHeldPanelButtons()
	{
	}

	private void UpdateHandButton(EquipmentSlotType handSlot)
	{
	}

	private HudHeldButton GetHeldButtonForHand(EquipmentSlotType handSlot)
	{
		return null;
	}

	public void UseSubstanceInHand(string hand)
	{
	}

	public IEnumerator OnSubstanceUse(InventoryItem substance, Hand hand)
	{
		return null;
	}

	private void ApplySubstanceNotification(InventoryItem substance)
	{
	}

	private void UseSubstance(InventoryItem item)
	{
	}

	public static int SubstanceUsedAmount(string substance)
	{
		return 0;
	}

	private static void SubstanceChargeUsed(string substance)
	{
	}

	public static bool SubstanceInitiationDone(string substance)
	{
		return false;
	}
}

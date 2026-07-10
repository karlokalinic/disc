using System.Collections;
using PixelCrushers;
using PixelCrushers.DialogueSystem;
using PixelCrushers.DialogueSystem.Wrappers;
using Sunshine;
using Sunshine.Metric;
using Sunshine.Views;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SunshineResponseButtonPageSystem : TextMeshProResponseButton, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	public static bool RebuildLayout;

	private const string colorString = "<color=#D0D5C2>";

	private const string blackColorString = "<color=#000000>";

	private const string GAIN_ITEM_ENTRY = "GainItem";

	private Image imageComponent;

	public Sprite transparentBackround;

	public Sprite lineBackground;

	public ResponseText optionText;

	private bool redCheck;

	private bool whiteCheck;

	private bool fakeCheck;

	private bool initialized;

	private Color regularColor;

	private Color highlightColor;

	private Color backgroundColor;

	private Color backgroundHighlightColor;

	private TooltipDataHolder checkHolderComponent;

	private TooltipSource tooltipSourceComponent;

	private DialogueEntry entry;

	private string stringFormat;

	private PixelCrushers.UIButtonKeyTrigger keyTrigger;

	private TextMeshProUGUI[] texts;

	private string prevLanguage;

	private ViewType prevViewType;

	private IEnumerator delayedSwitchedViewCoR;

	private IEnumerator localizeResponseCoR;

	private Vector3[] corners;

	private bool IsMasked => false;

	public override void InitialState(Response response, Transform target, int buttonNumber, UIAutonumberSettings autonumber)
	{
	}

	private void Update()
	{
	}

	private void GetData(DialogueEntry entry)
	{
	}

	private InventoryItem FindItemInResponse()
	{
		return null;
	}

	private string GetItemFromString(string gainItemString)
	{
		return null;
	}

	private void BlackenNumberingText()
	{
	}

	private void StyleRegular()
	{
	}

	private void StyleMoney()
	{
	}

	private void StyleSeenMoney()
	{
	}

	private void StyleWhiteCheck()
	{
	}

	private void StyleRedCheck()
	{
	}

	private void StyleHiddenTest()
	{
	}

	private void StyleDisabledColor()
	{
	}

	private void StyleNoMoneyColor()
	{
	}

	private void StyleSeen()
	{
	}

	private void ParseStringFormat()
	{
	}

	public void RegisterClick()
	{
	}

	protected void PlaySound()
	{
	}

	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	public void OnPointerExit(PointerEventData eventData)
	{
	}

	private void ShowHighlight()
	{
	}

	private void ShowNormal()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnSwitchedView(ViewType nextType)
	{
	}

	private void StartDelayedOnResponseLocalized(int frames)
	{
	}

	private IEnumerator DelayedOnSwitchedView(int skippedFrames)
	{
		return null;
	}

	public void OnResponseLocalized()
	{
	}

	private void StartDelayedOnLocalizeResponse(int frames)
	{
	}

	private IEnumerator DelayedOnLocalizeResponse(int skippedFrames)
	{
		return null;
	}

	private void LocalizeResponse()
	{
	}

	public override void Initialize()
	{
	}

	public override void ResetState()
	{
	}
}

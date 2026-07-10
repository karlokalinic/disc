using System.Collections;
using Coffee.UISoftMask;
using PixelCrushers;
using PixelCrushers.DialogueSystem;
using PixelCrushers.DialogueSystem.Wrappers;
using Sunshine;
using Sunshine.Metric;
using Sunshine.Views;
using TMPro;
using TwitchIntegration.JSON.Poll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SunshineResponseButton : TextMeshProResponseButton, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	public static bool RebuildLayout;

	public static GameObject lastSelectedResponse;

	public static Color HighestVoteColor;

	public static Color VoteOptionColor;

	private const string colorString = "<color=#D0D5C2>";

	private const string blackColorString = "<color=#000000>";

	private const string GAIN_ITEM_ENTRY = "GainItem";

	private Image imageComponent;

	private SoftMaskable softMaskable;

	public string voteString;

	private int twitchVoteID;

	public Sprite transparentBackround;

	public Sprite lineBackground;

	public ResponseText optionText;

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

	private SpecialFontHandler[] specialFontHandler;

	private int buttonNumber;

	private string prevLanguage;

	private ViewType prevViewType;

	private IEnumerator delayedSwitchedViewCoR;

	private IEnumerator localizeResponseCoR;

	private Vector3[] corners;

	private GetDialoguePoll localDialogPollData;

	public bool redCheck { get; private set; }

	public bool whiteCheck { get; private set; }

	private Sunshine.ConversationLogger conversationLogger => null;

	private bool IsMasked => false;

	public string GetCurrentText => null;

	public string GetCleanText => null;

	public override void InitialState(Response response, Transform target, int buttonNumber, UIAutonumberSettings autonumber)
	{
	}

	private void Update()
	{
	}

	private void ScrollToSelectedResponse()
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

	private void ForceCloseVotePoll()
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

	private void OnTwitchDialogPollStarted()
	{
	}

	private void OnTwitchDialogPollClosed()
	{
	}

	private void OnTwitchDialogPollDataRecieved(GetDialoguePoll dialogPollData)
	{
	}

	private void OnTwitchDialogPollForcedClosed()
	{
	}

	private void UpdateTwitchPollPercent(GetDialoguePoll dialogPollData)
	{
	}

	private void RefreshVoteString()
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

	private IEnumerator RefreshMaskable()
	{
		return null;
	}
}

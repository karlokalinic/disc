using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class JournalWhiteCheckUI : Selectable, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerClickHandler, ISelectHandler, IDeselectHandler
{
	public static JournalWhiteCheckUI CURRENTLY_SELECTED_CHECK;

	public Color actorTextLockedColor;

	public Color actorTextOpenColor;

	public Color actorTextDisplayedColor;

	public Color actorTextHighlightColor;

	public Color actorTextSelectedOpenColor;

	public Color actorTextSelectedClosedColor;

	[Space]
	public Color backgroundLockedColor;

	public Color backgroundOpenColor;

	public Color backgroundDisplayedColor;

	public Color backgroundHighlightColor;

	public Color backgroundSelectedOpenColor;

	public Color backgroundSelectedClosedColor;

	[Space]
	public Color difficultyLockedColor;

	public Color difficultyOpenColor;

	public Color difficultyDisplayedColor;

	public Color difficultyHighlightColor;

	public Color difficultySelectedOpenColor;

	public Color difficultySelectedClosedColor;

	public Image selectionBackground;

	public Image freshDot;

	[Space]
	public TextMeshProUGUI actorText;

	public TextMeshProUGUI prefixText;

	public TextMeshProUGUI skillText;

	public TextMeshProUGUI difficultyText;

	public bool isUpdated;

	public WhiteCheck whiteCheck;

	private bool isReopened;

	private bool isSeen;

	private static string DIFFICULTY_TEMPLATE => null;

	protected override void Awake()
	{
	}

	public void SetupCheck(WhiteCheck whiteCheck, bool hasNotificationApple)
	{
	}

	public void SetupSeenCheck(WhiteCheck whiteCheck)
	{
	}

	private void UpdateSeenCheck()
	{
	}

	public void UpdateCheck()
	{
	}

	public void Visualize()
	{
	}

	private void ScheduleJournalNotificationApple()
	{
	}

	private void ShowNotificationApple()
	{
	}

	public void OnPointerClick(PointerEventData eventData)
	{
	}

	public void SelectThisCheck(JournalWhiteCheckUI oldCheck)
	{
	}

	public override void OnPointerEnter(PointerEventData eventData)
	{
	}

	public override void OnPointerExit(PointerEventData eventData)
	{
	}

	public override void OnSelect(BaseEventData eventData)
	{
	}

	public override void OnDeselect(BaseEventData eventData)
	{
	}

	public void Remove()
	{
	}

	public bool IsCheckReopened()
	{
		return false;
	}

	protected override void OnDestroy()
	{
	}

	private void UpdateColors()
	{
	}

	private void UpdateColorsToHighlighted()
	{
	}

	private void UpdateColorsToDisplayed()
	{
	}

	private void UpdateColorsToOpen()
	{
	}

	private void UpdateColorsToLocked()
	{
	}

	private void UpdateColorsToSelectedOpen()
	{
	}

	private void UpdateColorsToSelectedClosed()
	{
	}

	private void UpdateElementsByFreshness()
	{
	}

	private void UpdateSkillTextAndColor()
	{
	}

	private void UpdateDifficultyText()
	{
	}

	private bool IsCheckLocked()
	{
		return false;
	}
}

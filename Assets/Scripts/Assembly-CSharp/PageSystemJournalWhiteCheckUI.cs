using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PageSystemJournalWhiteCheckUI : Selectable, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerClickHandler, ISelectHandler, IDeselectHandler
{
	public static PageSystemJournalWhiteCheckUI CURRENTLY_SELECTED_CHECK;

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
	public TextMeshProUGUI titleText;

	public bool isUpdated;

	public WhiteCheck whiteCheck;

	private const string TITLE_FORMAT = "<color=#{0}><b>{1}</b></color> (<color=#{2}>{3}</color>:\u00a0{4}";

	private bool isReopened;

	private bool isSeen;

	private Color actorColor;

	private Color difficultyColor;

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

	public void SelectThisCheck(PageSystemJournalWhiteCheckUI oldCheck)
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

	private string GetActorText()
	{
		return null;
	}

	private string GetSkillText()
	{
		return null;
	}

	private Color GetSkillColor()
	{
		return default(Color);
	}

	private string GetDifficultyText()
	{
		return null;
	}

	private bool IsCheckLocked()
	{
		return false;
	}
}

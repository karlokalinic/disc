using System.Collections;
using Sunshine.Metric;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class StatPanel : Selectable, ICharsheetSelecteble, ISubmitHandler, IEventSystemHandler
{
	public PipVisualizer statPips;

	public TextMeshProUGUI statName;

	public TextMeshProUGUI statNumber;

	public Image selectionMarker;

	public AbilityGradeFlipClock abilityGradeFlipClock;

	public StatLeveler leveler;

	public AbilityType ability;

	private bool isHovered;

	private bool isLerping;

	public void InitData()
	{
	}

	public void ChangeToSetSkills(AnimationCurve Curve, float Duration)
	{
	}

	public void ChangeToAdjustAbilities(AnimationCurve Curve, float Duration)
	{
	}

	private IEnumerator UpdateTextColor(Color ColorFrom, Color ColorTo, AnimationCurve Curve, float Duration)
	{
		return null;
	}

	private IEnumerator UpdateTextColorBack(Color ColorFrom, Color ColorTo, AnimationCurve Curve, float Duration)
	{
		return null;
	}

	public void UpdateData()
	{
	}

	private bool CanUpgradeAbility(int num)
	{
		return false;
	}

	private bool CanDowngradeAbility(int num)
	{
		return false;
	}

	public override void OnSelect(BaseEventData eventData)
	{
	}

	public override void OnDeselect(BaseEventData eventData)
	{
	}

	public override void OnPointerDown(PointerEventData eventData)
	{
	}

	public void OnSubmit(BaseEventData eventData)
	{
	}

	private void SelectThis()
	{
	}

	public void UpdateSelectionVisuals()
	{
	}

	public Modifiable GetModifiable()
	{
		return null;
	}

	public override void OnPointerEnter(PointerEventData eventData)
	{
	}

	public override void OnPointerExit(PointerEventData eventData)
	{
	}

	private void Update()
	{
	}

	public string GetGameObjectName()
	{
		return null;
	}

	public bool HaveInfoTabAvailable()
	{
		return false;
	}
}

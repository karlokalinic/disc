using System.Collections;
using Sunshine.Metric;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace DiscoPages.Elements.Charsheet
{
	public class PageSystemStatPanel : Selectable, ICharsheetSelecteble, ISubmitHandler, IEventSystemHandler
	{
		public Button tmpSkillOverviewPageButton;

		[SerializeField]
		private RectTransform minimal;

		[SerializeField]
		private RectTransform maximal;

		public PipVisualizer statPips;

		public PipVisualizer statPipsMin;

		public TextMeshProUGUI statName;

		public TextMeshProUGUI statNameMin;

		public TextMeshProUGUI statNumber;

		public Image selectionMarker;

		public AbilityGradeFlipClock abilityGradeFlipClock;

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

		public void UpdateData(CharSheetMode sheetMode)
		{
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

		public void Maximize()
		{
		}

		public void Minimize()
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
}

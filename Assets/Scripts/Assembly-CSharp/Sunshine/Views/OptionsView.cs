using System;
using System.Collections.Generic;
using Sunshine.Feld;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Sunshine.Views
{
	public class OptionsView : View
	{
		[SerializeField]
		private ScrollRect optionsScroll;

		[SerializeField]
		private Selectable firstSelectable;

		[SerializeField]
		private Selectable alternativeSelectableFallback;

		[SerializeField]
		private TMP_Dropdown[] dropdownsToHide;

		[SerializeField]
		private VerticalStepScrollView verticalStepScrollView;

		[HideInInspector]
		public Selectable lastSelectedSelectable;

		private HashSet<SliderButtonHandler> slidersSet;

		public Selectable FirstSelectable => null;

		public void AddSlider(SliderButtonHandler slider)
		{
		}

		public void RemoveSlider(SliderButtonHandler slider)
		{
		}

		private void ActivateSliders()
		{
		}

		private void DeactivateSliders()
		{
		}

		public override ViewType GetViewType()
		{
			return default(ViewType);
		}

		public override FeldView GetFeldViewType()
		{
			return default(FeldView);
		}

		public override void InitTransforms()
		{
		}

		public override bool CanTransitionFromCurrentView()
		{
			return false;
		}

		public override void SwitchToView(ViewType previousView)
		{
		}

		public override void OnExitView(ViewType nextView)
		{
		}

		public override void SetInitialSelect()
		{
		}

		protected override void OnFrameAfterSwitchedToCompleated()
		{
		}

		private TMP_Dropdown GetExpandedDropdown()
		{
			return null;
		}

		private void HideExpandedDropdownOrAction(Action actionOnNoExpandedDropdown)
		{
		}

		protected override void CloseOnUICancel()
		{
		}

		protected override void CloseOnEscapeKey()
		{
		}
	}
}

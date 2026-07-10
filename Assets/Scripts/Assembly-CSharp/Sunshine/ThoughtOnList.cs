using System;
using System.Runtime.CompilerServices;
using I2.Loc;
using Sunshine.Metric;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Sunshine
{
	public class ThoughtOnList : Selectable, ISelectHandler, IEventSystemHandler
	{
		[NonSerialized]
		public SelectionNavigationGroup thoughtEntriesSelectionGroup;

		[SerializeField]
		private TextMeshProUGUI _text;

		[SerializeField]
		private Localize _textLocalize;

		[SerializeField]
		private Image _fillingImage;

		[SerializeField]
		private Image _backgroundImage;

		[SerializeField]
		private Image _leftBlock;

		[SerializeField]
		private Image _icon;

		[SerializeField]
		private TextMeshProUGUI _researchProgressText;

		private bool _isSelected;

		private bool _isUpdated;

		private bool _selectionChanged;

		private static readonly float _blinkingAnimationTime;

		private static readonly float _animationTime;

		public ThoughtCabinetProject Project { get; private set; }

		private event Action<ThoughtCabinetProject> OnClicked
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public void Init()
		{
		}

		public void SetProject(ThoughtCabinetProject project)
		{
		}

		public bool Selected()
		{
			return false;
		}

		public void SelectThis()
		{
		}

		public void SelectFromSlot()
		{
		}

		public void Deselect()
		{
		}

		public void UpdateThought()
		{
		}

		public override void OnSelect(BaseEventData eventData)
		{
		}

		public void Refresh()
		{
		}

		private void ChangeTextColor(TextMeshProUGUI obj, Color targetColor)
		{
		}

		private void ChangeImageColor(Image obj, Color targetColor)
		{
		}

		private void SetSelectedState(bool value)
		{
		}

		private void OnClickedHandler()
		{
		}

		public override void OnPointerEnter(PointerEventData pointer)
		{
		}
	}
}

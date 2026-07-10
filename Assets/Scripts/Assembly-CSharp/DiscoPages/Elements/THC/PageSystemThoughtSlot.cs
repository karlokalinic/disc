using System;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Sunshine;
using Sunshine.Metric;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

namespace DiscoPages.Elements.THC
{
	public class PageSystemThoughtSlot : Selectable, IPointerClickHandler, IEventSystemHandler, IPointerEnterHandler, IPointerExitHandler, ISelectHandler, IDeselectHandler, ISubmitHandler
	{
		[HideInInspector]
		public bool HasButton;

		[HideInInspector]
		public GameObject UnlockButton;

		[HideInInspector]
		public Button interactButtonUnlock;

		[HideInInspector]
		public ThoughtInteractButton interactButtonThought;

		public Transform PlaceForUnlockButton;

		private const int DOUBLE_FRAME_JUMPS_AMOUNT = 3;

		[SerializeField]
		private Animation _anim;

		[SerializeField]
		private ThoughtSlotActionButton _actionButton;

		[SerializeField]
		[Space]
		private Image _slotImage;

		[SerializeField]
		private Image _doubleFrame;

		[SerializeField]
		private Image _thoughtProjectImage;

		[SerializeField]
		[Space]
		private Image _fillableArea;

		[SerializeField]
		private Image _fillableAreaBackground;

		[SerializeField]
		private TextMeshProUGUI _thoughtNameText;

		[SerializeField]
		private Image _unlockSlotStarPip;

		private PageSystemThoughtSlotHover _slotHover;

		private Action<PageSystemThoughtSlot> OnEmptySlotClicked;

		private bool _willShowActionButton;

		private bool _isSelected;

		private bool _isMouseOverThis;

		private bool _selectionChanged;

		private static readonly float _animationTime;

		private static readonly float _blinkingAnimationTime;

		private static readonly float _fixingThoughtAnimationTime;

		private static readonly float _acidAnimationTime;

		private static readonly float _doubleFrameOpeningTime;

		private static readonly float _doubleFrameClosingTime;

		private static readonly float _doubleFrameCloseScale;

		private static readonly float _doubleFramOpenScale;

		private const string BUYABLE_IMAGE_PATH = "slot/buyableX";

		private const string FREE_IMAGE_PATH = "slot/open";

		private const string FILLED_IMAGE_PATH = "slot/open";

		private const string FIXED_IMAGE_PATH = "slot/fixed";

		private const string LOCKED_IMAGE_PATH = "slot/closed";

		private const string THOUGHT_IMAGE_PATH = "thought_icons/";

		private const string MATERIAL_BOTTOM_START = "_BottomDimStartY";

		private const string MATERIAL_BOTTOM_END = "_BottomDimEndY";

		private const string MATERIAL_DIMVALUE = "_DimValue";

		public Sequence sequence;

		private static string UNLOCKABLE => null;

		public ThoughtSlot.SlotState State { get; private set; }

		public ThoughtCabinetProject Project { get; private set; }

		public bool IsSelected => false;

		public bool SelectionChanged => false;

		public bool IsDoubleSelected => false;

		private ThoughtSlotStateObject SlotConfig => null;

		public int SlotIndex { get; set; }

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

		protected override void Awake()
		{
		}

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		private void OnLanguageChanged()
		{
		}

		public void OnClickedAddListener(Action<ThoughtCabinetProject> action)
		{
		}

		public void OnEmptySlotClickedAddListener(Action<PageSystemThoughtSlot> action)
		{
		}

		public void Init()
		{
		}

		public void SetProject(ThoughtCabinetProject project)
		{
		}

		public void RefreshTexts()
		{
		}

		public void SetFixed()
		{
		}

		public void SetFree()
		{
		}

		public void RemoveThought()
		{
		}

		public void SetLocked()
		{
		}

		public void SetBuyable()
		{
		}

		public void SetupActionButton(UnityAction action, Sprite buttonSprite, int cost = 0)
		{
		}

		public void SelectThis()
		{
		}

		public void Deselect()
		{
		}

		public void Refresh()
		{
		}

		public void HideName()
		{
		}

		public void StartBlinkingSlot()
		{
		}

		public void StopBlinkingSlot()
		{
		}

		public void StartBlinkingProjectImage()
		{
		}

		public void StopBlinkingProjectImage()
		{
		}

		public void AddProjectImagePreview(Sprite sprite)
		{
		}

		public void ClearProjectImagePreview()
		{
		}

		public void AnimateFixingThought(int animateOrder)
		{
		}

		private void AnimateForgettingThought()
		{
		}

		private void ChangeTextColor(TextMeshProUGUI obj, Color targetColor)
		{
		}

		private void ChangeImageColor(Image obj, Color targetColor)
		{
		}

		private void FindAndSetThoughtImage()
		{
		}

		public void RefreshImage()
		{
		}

		private void FindAndSetThoughtName()
		{
		}

		public void OnPointerClick(PointerEventData eventData)
		{
		}

		public override void OnPointerEnter(PointerEventData eventData)
		{
		}

		public override void OnPointerExit(PointerEventData eventData)
		{
		}

		public void OnSubmit(BaseEventData baseEvent)
		{
		}

		private void OnClickedHandler()
		{
		}

		private void SetSelectedState(bool value)
		{
		}

		public void SetStateFromPersistence(ThoughtSlot.SlotState state, string projectName)
		{
		}
	}
}

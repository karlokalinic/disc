using System;
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
	public class PageSystemThoughtOceanSlot : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
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

		[Space]
		[SerializeField]
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

		private Action<PageSystemThoughtOceanSlot> OnEmptySlotClicked;

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

		private const string FRESH_IMAGE_PATH = "slot/fresh";

		private const string FILLED_IMAGE_PATH = "slot/open";

		private const string FIXED_IMAGE_PATH = "slot/fixed";

		private const string LOCKED_IMAGE_PATH = "slot/closed";

		private const string THOUGHT_IMAGE_PATH = "thought_icons/";

		private const string MATERIAL_BOTTOM_START = "_BottomDimStartY";

		private const string MATERIAL_BOTTOM_END = "_BottomDimEndY";

		private const string MATERIAL_DIMVALUE = "_DimValue";

		public Sequence sequence;

		public AnimationCurve progressToShaderEvalCurve;

		private static string UNLOCKABLE => null;

		public ThoughtSlot.SlotState State { get; private set; }

		public ThoughtCabinetProject Project { get; private set; }

		private ThoughtSlotStateObject SlotConfig => null;

		public int SlotIndex { get; set; }

		protected void OnEnable()
		{
		}

		public void ClearSpritesFromImages()
		{
		}

		protected void OnDisable()
		{
		}

		private void OnLanguageChanged()
		{
		}

		public void OnEmptySlotClickedAddListener(Action<PageSystemThoughtOceanSlot> action)
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

		private void OnClickedHandler()
		{
		}
	}
}

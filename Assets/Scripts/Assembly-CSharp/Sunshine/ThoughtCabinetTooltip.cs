using System.Collections;
using LocalizationCustomSystem;
using Sunshine.Metric;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Voidforge;

namespace Sunshine
{
	public class ThoughtCabinetTooltip : SingletonComponent<ThoughtCabinetTooltip>
	{
		[SerializeField]
		private Scrollbar descriptionScrollbar;

		[SerializeField]
		private Image mainImage;

		[SerializeField]
		private Image mainImageSecondary;

		[SerializeField]
		private TextMeshProUGUI titleUp;

		[SerializeField]
		private TextMeshProUGUI title;

		[SerializeField]
		private TextMeshProUGUI properties;

		[SerializeField]
		private GameObject propertiesHolder;

		[SerializeField]
		private GameObject finishedThoughtEffect;

		[SerializeField]
		private TextMeshProUGUI description;

		[SerializeField]
		private GameObject controllerButtonPrompts;

		[SerializeField]
		private LocalizedTooltipDescription buttonLocalizedTooltipContent;

		[SerializeField]
		private TooltipSource buttonTooltipSource;

		[SerializeField]
		private ThoughtInteractButton buttonThought;

		[SerializeField]
		private Button interactButton;

		[SerializeField]
		private TranslationString unlockButtonTerm;

		[SerializeField]
		private TranslationString grayUnlockButtonTerm;

		[SerializeField]
		private TranslationString cancelButtonTerm;

		[SerializeField]
		private TranslationString forgetButtonTerm;

		[SerializeField]
		private TranslationString grayForgetButtonTerm;

		[SerializeField]
		private TranslationString internalizeButtonTerm;

		[SerializeField]
		private TranslationString grayInternalizeButtonTerm;

		[SerializeField]
		private GameObject tabsParent;

		[SerializeField]
		[Space]
		private TweenRectTransform tweenBackground;

		[Space]
		[SerializeField]
		private Button problemButton;

		[SerializeField]
		private TextMeshProUGUI problemText;

		[Space]
		[SerializeField]
		private Button solutionButton;

		[SerializeField]
		private TextMeshProUGUI solutionText;

		[Space]
		[SerializeField]
		private GameObject problemSolutionSlash;

		[SerializeField]
		private XPPanel xpPanel;

		[SerializeField]
		private string pathToThoughtsImages;

		[SerializeField]
		private string fullPathToThoughtTreeImage;

		public AnimationCurve progressToShaderEvalCurve;

		protected string _source;

		private ThoughtCabinetProject thought;

		private Material mainImageMaterial;

		private const string MATERIAL_DIMVALUE = "_DimValue";

		private Button interactButtonUnlockTemp;

		private int unlockSlotCost;

		private int forgetThoughtCost;

		private bool isProblemShown;

		private Coroutine resetScrollCor;

		public string Source
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void OnLanguageChanged()
		{
		}

		private IEnumerator DelayedUpdateTweenBackground()
		{
			return null;
		}

		public static void Show(string source)
		{
		}

		public static void ShowUnlockButtonCommand(ThoughtSlot slot, Transform Position)
		{
		}

		public static void ShowSlotTooltip(ThoughtSlot.SlotState state)
		{
		}

		private void ShowUnlockButton(ThoughtSlot slotState, Transform Position)
		{
		}

		private void ShowTooltip()
		{
		}

		private void UnlockButtonInvoker(ThoughtSlot slotState, ThoughtInteractButton interactButtonThought, Button interactButtonUnlock)
		{
		}

		private void ShowTreeDescription(ThoughtSlot.SlotState slotState)
		{
		}

		public void OnUnlockSlotClickedInstance(Button interactButtonUnlock)
		{
		}

		private void BuySlot()
		{
		}

		private void CancelSlotBuying()
		{
		}

		public void Hide()
		{
		}

		public void SetSource(string source)
		{
		}

		protected void UseSource(string itemName)
		{
		}

		private void PrimeThought(string thoughtName)
		{
		}

		private void HideSolutionTab()
		{
		}

		private void ShowSolutionTab()
		{
		}

		private void AddImageToTapeArtSwapper(Sprite image)
		{
		}

		private void SetTab(bool showProblem)
		{
		}

		private void SetPropertiesDescription(bool isFixed, bool first)
		{
		}

		private bool HasEnoughSkillPoints(int cost)
		{
			return false;
		}

		private void SpendSkillPoints(int cost)
		{
		}

		public bool SelectionBelongToThisObject(Selectable selectable)
		{
			return false;
		}

		public void SelectDefault()
		{
		}

		private IEnumerator ResetScroll()
		{
			return null;
		}

		private void StartResetScroll()
		{
		}
	}
}

using System;
using LocalizationCustomSystem;
using Sunshine.Metric;
using Sunshine.Views;
using UnityEngine;
using Voidforge;

namespace Sunshine
{
	public class ThoughtManager : SingletonComponent<ThoughtManager>
	{
		[SerializeField]
		private bool isDebugOn;

		private ThoughtSlot lastSlot;

		public int slotsBought;

		public Action<ThoughtCabinetProject, bool> OnThoughtSelected;

		public Action<ThoughtCabinetProject> OnThoughtDeselected;

		public Action OnThoughtDeselectedForSlot;

		public Action<ThoughtSlot> OnEmptySlotSelected;

		public ThoughtSlotStateManager thoughtSlotStateManager;

		[SerializeField]
		private ThoughtSlotsTree _slotsTree;

		[SerializeField]
		private AllThoughtsList _thoughtList;

		[SerializeField]
		private TranslationString _viewTitle;

		[SerializeField]
		private TranslationString _viewDescription;

		[SerializeField]
		private TranslationString _emptySlotDescription;

		[SerializeField]
		private TranslationString _unlockableSlotDescription;

		[SerializeField]
		private Sprite _emptySlotImage;

		[SerializeField]
		private Sprite _unlockableSlotImage;

		[SerializeField]
		private Sprite _updatedIcon;

		[SerializeField]
		private Sprite _lockedIcon;

		[SerializeField]
		private FontTranslationString fontNormalTerm;

		[SerializeField]
		private FontTranslationString fontBoldTerm;

		[SerializeField]
		private Color _colorTextForgotten;

		[SerializeField]
		private Color _colorTextUnknown;

		[SerializeField]
		private Color _colorTextKnown;

		[SerializeField]
		private Color _colorTextCooking;

		[SerializeField]
		private Color _colorTextSelected;

		[SerializeField]
		[Space]
		private Color _colorTextTabSelected;

		[SerializeField]
		private Color _colorTextTabDeselected;

		[SerializeField]
		[Space]
		private Color _colorTextGreyed;

		[SerializeField]
		[Space]
		private Color _colorTextProblem;

		[SerializeField]
		private Color _colorTextSolution;

		[SerializeField]
		private Color _colorTextProperties;

		[SerializeField]
		private Color _colorTextPropertiesSolved;

		[SerializeField]
		private Color _colorBackgroundCooking;

		[SerializeField]
		private Color _colorBackgroundFixed;

		[SerializeField]
		private Color _colorBackgroundSelected;

		[SerializeField]
		private Color _colorResearchFillingImage;

		[SerializeField]
		private Color _colorLeftBlockSelected;

		[SerializeField]
		private Color _colorLeftBlockDeselected;

		[SerializeField]
		private Color _colorLeftIconSelected;

		[SerializeField]
		private Color _colorLeftIconDeselected;

		[Space]
		[SerializeField]
		private int _costForgetThought;

		[SerializeField]
		private int[] _costUnlockSlot;

		public AnimationCurve thoughtIconCurve;

		public ThoughtCabinetProject _selectedProject { get; set; }

		public ThoughtCabinetViewPersister.ThoughtCabinetViewState SerializedSlotsState { get; set; }

		public string ViewTitle => null;

		public string ViewDescription => null;

		public string UnlockableSlotDescription => null;

		public string EmptySlotDescription => null;

		public string FontNormalTerm => null;

		public string FontBoldTerm => null;

		public Color ColorTextForgotten => default(Color);

		public Color ColorTextUnknown => default(Color);

		public Color ColorTextKnown => default(Color);

		public Color ColorTextCooking => default(Color);

		public Color ColorTextSelected => default(Color);

		public Color ColorTextTabSelected => default(Color);

		public Color ColorTextTabDeselected => default(Color);

		public Color ColorTextProblem => default(Color);

		public Color ColorTextSolution => default(Color);

		public Color ColorTextPropertiesSolved => default(Color);

		public Color ColorTextProperties => default(Color);

		public Color ColorBackgroundCooking => default(Color);

		public Color ColorBackgroundFixed => default(Color);

		public Color ColorBackgroundSelected => default(Color);

		public Color ColorResearchFillingImage => default(Color);

		public Color ColorLeftBlockSelected => default(Color);

		public Color ColorLeftBlockDeselected => default(Color);

		public Color ColorLeftIconSelected => default(Color);

		public Color ColorLeftIconDeselected => default(Color);

		public Sprite EmptySlotImage => null;

		public Sprite UnlockableSlotImage => null;

		public Sprite UpdatedIcon => null;

		public Sprite LockedIcon => null;

		public ThoughtSlotsTree SlotsTree => null;

		public int CostForgetThought => 0;

		public int[] CostUnlockSlot => null;

		public int CostUnlockNextSlot => 0;

		public void OnInputKey()
		{
		}

		protected void Start()
		{
		}

		private void Update()
		{
		}

		public void NotifyActivation()
		{
		}

		public void NotifyDeactivation(ViewType nextView)
		{
		}

		public void ResetView(bool setDefaultSorting = true)
		{
		}

		public void RefreshThought(ThoughtCabinetProject project)
		{
		}

		public void UpdateThought(ThoughtCabinetProject project)
		{
		}

		public void RemoveThought(ThoughtCabinetProject project)
		{
		}

		public void ProcessThought(ThoughtCabinetProject project)
		{
		}

		public void CancelProcessingThought(ThoughtCabinetProject project)
		{
		}

		public void BakeThoughts(int timePassed)
		{
		}

		public void ReinitializeThoughtsList()
		{
		}

		public bool HasBreakthroughThougts()
		{
			return false;
		}

		private void RefreshTree()
		{
		}

		private void RefreshList(bool setDefaultSorting = true)
		{
		}

		private void UnequipThought(ThoughtCabinetProject project)
		{
		}

		public void SelectThought(string projectDisplayName)
		{
		}

		public void SelectThought(ThoughtCabinetProject project, bool fromList)
		{
		}

		public void SelectEmptySlot(ThoughtSlot slot)
		{
		}

		public void OnEmptySlotClicked(ThoughtSlot slot)
		{
		}

		private void UnfreshThought(ThoughtCabinetProject project)
		{
		}

		public void AddDisoveredThoughtToAnimate(ThoughtCabinetProject project)
		{
		}

		private void DeselectThought(ThoughtCabinetProject project)
		{
		}

		private void DeselectThoughtForSlot()
		{
		}

		private void OnThoughtSelectedHandler(ThoughtCabinetProject project, bool fromList)
		{
		}

		private void OnThoughtDeselectedForSlotHandler()
		{
		}

		private void OnThoughtDeselectedHandler(ThoughtCabinetProject project)
		{
		}

		private void OnEmptySlotSelectedHandler(ThoughtSlot slot)
		{
		}

		public static bool WillShowSplashScreenInstead()
		{
			return false;
		}

		public void SetDefaultSelection()
		{
		}

		public void ChangeNavigationGroupInUse()
		{
		}

		public void RegisterEvents()
		{
		}

		public void UnregisterEvents()
		{
		}
	}
}

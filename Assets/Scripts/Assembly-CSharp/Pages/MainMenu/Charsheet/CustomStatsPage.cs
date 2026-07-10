using System;
using System.Collections.Generic;
using Sunshine.Metric;
using Sunshine.Views;
using UnityEngine;
using UnityEngine.UI;

namespace Pages.MainMenu.Charsheet
{
	public class CustomStatsPage : DiscoPage
	{
		private CharacterSheet character;

		public AbilityMethod abilityMethod;

		[NonSerialized]
		public int unusedAbilityPool;

		[NonSerialized]
		public int usedAbilityPoints;

		[NonSerialized]
		public int usedSkillPoints;

		[SerializeField]
		private Button resetButton;

		[SerializeField]
		private Button randomizeButton;

		[SerializeField]
		private Button skillsNavigateButton;

		[SerializeField]
		private AnimationCurve CurveToBlack;

		[SerializeField]
		private AnimationCurve CurveToGray;

		public float ChangeColorDuration;

		[SerializeField]
		protected StatPanel[] statPanels;

		private int startingSkillPoints;

		private static CustomStatsPage singleton;

		public Dictionary<SkillType, int> StartingRanks;

		public Action OnLevelupFinalized;

		internal Action<CharSheetMode> OnViewModeChanged;

		public static CustomStatsPage Singleton => null;

		public CharacterSheet Character => null;

		public bool HasStarted { get; private set; }

		public bool HasSavepoint { get; private set; }

		public bool IsNewCharInitialized { get; private set; }

		public static int MaxSkillPoints => 0;

		protected CharSheetMode charSheetMode => default(CharSheetMode);

		public void SetStatPanelGray()
		{
		}

		public void SetStatPanelBlack()
		{
		}

		public override void Initialize()
		{
		}

		public void OnEnable()
		{
		}

		public void InitData()
		{
		}

		public void ForceInitCharacter()
		{
		}

		public void InitCharacter(bool forceInit = false)
		{
		}

		public void RevertAbilities()
		{
		}

		public void OnExitResetIfNecessary()
		{
		}

		public void ResetCreateSheet()
		{
		}

		public void ResetSpentPoints()
		{
		}

		public void OnCreationDesintegrationFinished()
		{
		}

		public void OnCharacterCreationFinalized()
		{
		}

		public void NotifyActivation()
		{
		}

		public void NotifyDeactivation()
		{
		}

		public void CreateSavePoint()
		{
		}

		public void SubmitLevelUp()
		{
		}

		private void ResetSkillsOnCreation()
		{
		}

		private void RestoreFromSavePoint()
		{
		}

		public void ShowResetSpentPointsPrediction()
		{
		}

		public void HideResetSpentPointsPrediction()
		{
		}

		private void ShowRestoreFromSavePointPrediction()
		{
		}

		private void HideRestoreFromSavePointPrediction()
		{
		}

		public void SwitchMode(CharSheetMode nextSheetMode, bool notifyActivation = true)
		{
		}

		public void OnFailedExitAttempt(ViewType nextView)
		{
		}

		private void OnConfirm()
		{
		}

		private void OnGenericEndgame()
		{
		}

		private void OnWorldStarted()
		{
		}

		private void OnWorldStopped()
		{
		}
	}
}

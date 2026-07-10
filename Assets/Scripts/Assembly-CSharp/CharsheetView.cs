using System;
using System.Collections.Generic;
using I2.Loc;
using Sunshine.Metric;
using Sunshine.Views;
using UnityEngine;
using UnityEngine.UI;
using Voidforge;

public class CharsheetView : SingletonComponent<CharsheetView>
{
	public CharacterSheet character;

	public CharsheetAnimatorHelper animatorHelper;

	public AbilityMethod abilityMethod;

	[HideInInspector]
	public CharSheetMode sheetMode;

	public Localize titleLocalize;

	public RectTransform levelingTarget;

	public XPPanel xpPanel;

	public CharacterCreationTitleBar titleBar;

	public SkillPointField skillPointField;

	public SegmentIndicator abilityPipSegmentIndicator;

	[NonSerialized]
	public int unusedAbilityPool;

	[NonSerialized]
	public int usedAbilityPoints;

	[NonSerialized]
	public int usedSkillPoints;

	public Button skillsButton;

	public Button doneButton;

	public Button resetButton;

	public Button submitLevelUpButton;

	public AnimationCurve CurveToBlack;

	public AnimationCurve CurveToGray;

	public float ChangeColorDuration;

	protected StatPanel[] statPanels;

	protected SkillPanel[] skillPanels;

	protected SkillPortraitPanel[] skillPortraitPanels;

	public ConventionTutorialScreenFiddler tutorialScreenTemplate;

	private int startingSkillPoints;

	public Dictionary<SkillType, int> StartingRanks;

	public Action OnLevelupFinalized;

	internal Action<CharSheetMode> OnViewModeChanged;

	public KeyCode[] InputKeys => null;

	public bool HasStarted { get; private set; }

	public bool HasSavepoint { get; private set; }

	public bool IsNewCharInitialized { get; private set; }

	public static int MaxSkillPoints => 0;

	public void SetStatPanelGray()
	{
	}

	public void SetStatPanelBlack()
	{
	}

	protected override void Awake()
	{
	}

	public void OnInputKey()
	{
	}

	private void Update()
	{
	}

	public void Start()
	{
	}

	public void OnEnable()
	{
	}

	public void RegisterInterface()
	{
	}

	public void InitData()
	{
	}

	private void SetActiveElements()
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

	public void LevelingComplete()
	{
	}

	public void UnloadAsyncPortraits()
	{
	}

	public void OnCreationDesintegrationFinished()
	{
	}

	public void OnCharacterCreationFinalized()
	{
	}

	private void SpawnTutorialScreen()
	{
	}

	public void NotifyActivation(bool selectSignature = true)
	{
	}

	public void ResetStatPortraitVisuals()
	{
	}

	public void ShowSkillArray()
	{
	}

	public void HideSkillArray()
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

	public void SetDefaultButton()
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

	public ICharsheetSelecteble FindPanelWithName(string selectedPanelName)
	{
		return null;
	}

	public void UpdateSkillPortraitPanels(SkillPortraitPanel[] updatedSkillPortraitList)
	{
	}
}

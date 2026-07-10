using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using PixelCrushers.DialogueSystem;
using Sunshine;
using Sunshine.Metric;
using TMPro;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.UI;

public class CharacterSheetInfoPanel : LiteSingleton<CharacterSheetInfoPanel>
{
	public RectTransform largeTitle;

	public RectTransform smallTitle;

	public Image portrait;

	public RectTransform portraitMask;

	public RectTransform overviewSection;

	public RectTransform infoPanel;

	private TextMeshProUGUI smallTitleText;

	public TextMeshProUGUI textArea;

	public TextMeshProUGUI extraText;

	public TextMeshProUGUI infoText;

	public RectTransform skillDisplay;

	public TextMeshProUGUI bonusText;

	public Image bonusTextMinusImage;

	public RectTransform setSignatureTutorialText;

	public Button levelUpButton;

	public SkillLevelUpButton skillLevelUpButton;

	[SerializeField]
	private ButtonTooltip buttonTooltipContent;

	[SerializeField]
	private TooltipSource buttonTooltipSource;

	public Button signatureSkillButton;

	public GameObject tabPanel;

	[SerializeField]
	private Image leftTabIcon;

	[SerializeField]
	private Image rightTabIcon;

	public UnityEngine.UI.Toggle overviewToggle;

	public UnityEngine.UI.Toggle infoToggle;

	public RectTransform overviewLabel;

	public RectTransform overviewRect;

	public RectTransform infoLabel;

	public RectTransform infoRect;

	public TweenRectTransform tabsBackground;

	public bool textView;

	public RectTransform titlePadding;

	public CharacterSheetInfoPanelAnimator animator;

	public SegmentIndicator portraitSkillPipIndicator;

	public TextMeshProUGUI abilityValueText;

	public SkillPortraitAnimatorHelper skillPortraitAnimatorHelper;

	private static readonly int info;

	private bool isShown;

	private bool isAsyncPrepared;

	private string previousActorName;

	private AsyncOperationHandle<Sprite> spriteHandle;

	public ICharsheetSelecteble Selected { get; private set; }

	public StatPanel SelectedAbility => null;

	public SkillPortraitPanel SelectedSkill => null;

	public event Action<bool> OnInteractableChanged
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

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnLanguageChanged()
	{
	}

	public void UpdateTabSizes()
	{
	}

	private IEnumerator DelayedUpdateTabsRects()
	{
		return null;
	}

	protected override void Awake()
	{
	}

	private void Update()
	{
	}

	private void ForceMoveAndResizeTabs()
	{
	}

	public void JumpTabsPositionsAndResize()
	{
	}

	public void SetSelectedByString(string selectedPanelName)
	{
	}

	private IEnumerator WaitForCharacter(ICharsheetSelecteble charsheetSelecteble)
	{
		return null;
	}

	public void SetSelected(ICharsheetSelecteble newSelected, bool invokeSelect = true)
	{
	}

	public void OnBackgroundClicked()
	{
	}

	public void UpdateData(bool updateModifiable = true)
	{
	}

	public void ShowCharsheetInfo()
	{
	}

	public void ShowModifiable(Modifiable modifiable)
	{
	}

	private void ShowSkill(Skill skill)
	{
	}

	private void SetPortrait(Actor actor)
	{
	}

	public void UnloadPortraitAsync()
	{
	}

	private void SetTequillaPortrait()
	{
	}

	private void SetPortrait(AsyncOperationHandle<Sprite> portraitHandle)
	{
	}

	private void ShowAbility(Ability ability)
	{
	}

	private static string GatherModifiableData(Modifiable modifiable)
	{
		return null;
	}

	private static void PerceptionSpecialBehaviour(Modifiable modifiable, List<Modifier> modifiersToDisplay)
	{
	}

	public void ToggleOverview(bool isOn)
	{
	}

	public void ToggleInfo(bool isOn)
	{
	}

	public void DisableInfoToggle()
	{
	}

	public void EnableInfoToggle()
	{
	}

	private string GetCharsheetInfo()
	{
		return null;
	}

	public void Show()
	{
	}

	public void Hide()
	{
	}
}

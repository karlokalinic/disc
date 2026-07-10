using System;
using System.Runtime.CompilerServices;
using Charsheet;
using Sunshine.Metric;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.UI;

public class SkillPortraitPanel : MonoBehaviour, ISkillDisplayElement, ISkillPortraitLabelHandler, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, ICharsheetSelecteble
{
	public Image portrait;

	public Image frame;

	public bool isHovered;

	public bool isSelectHovered;

	public bool isUpgradeable;

	private bool isSignature;

	public Image signatureFrame;

	public SegmentIndicator skillPips;

	public Image selectionMarker;

	public Button levelUpButton;

	public Button setSignatureButton;

	public Button selectButton;

	private SkillPortraitAnimatorHelper animatorHelper;

	private PipVisualizer levelUpPips;

	public SkillPortrayLabel skillPortrayLabel;

	private int rankValue;

	private int statValue;

	public SkillPortraitMode mode;

	public SkillType skill;

	public static SkillType signatureSkill;

	private bool isInitialized;

	public Skill currentSkill;

	private bool isAsyncPrepared;

	private AsyncOperationHandle<Sprite> spriteHandle;

	public SkillType SkillType => default(SkillType);

	public SkillPortrayLabel SkillPortraitLabel => null;

	public static event Action OnSkillUpdated
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

	private void Awake()
	{
	}

	public void UpdateData(bool selectSignature = true)
	{
	}

	public void ResetValues()
	{
	}

	private void UpdateWithSkillObject(Skill skillObject, bool selectSignature = true)
	{
	}

	public void UpdateColors()
	{
	}

	public void UpdateSelectionVisuals()
	{
	}

	public void OnPointerEnter(PointerEventData evt)
	{
	}

	public void OnPointerExit(PointerEventData evt)
	{
	}

	public void OnSelectButtonClicked()
	{
	}

	public SkillType GetSkillType()
	{
		return default(SkillType);
	}

	public static void OnSkillUpgrade(SkillType skillType)
	{
	}

	public static void SetSignatureSkill(SkillType skillType)
	{
	}

	public Modifiable GetModifiable()
	{
		return null;
	}

	public void Show()
	{
	}

	public void Hide()
	{
	}

	public string GetGameObjectName()
	{
		return null;
	}

	public void SetSkill(Skill newSkill)
	{
	}

	public void LoadSkillPortraitAsync()
	{
	}

	public void UnloadSkillPortraitAsync()
	{
	}

	private void SetSkillPortrait(AsyncOperationHandle<Sprite> portraitHandle)
	{
	}

	public bool HaveInfoTabAvailable()
	{
		return false;
	}
}

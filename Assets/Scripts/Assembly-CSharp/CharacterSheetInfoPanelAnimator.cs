using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CharacterSheetInfoPanelAnimator : MonoBehaviour
{
	[SerializeField]
	private float overviewDuration;

	[SerializeField]
	private float infoDuration;

	[SerializeField]
	private CanvasGroup overviewSection;

	[SerializeField]
	private Image signatureSkillButton;

	[SerializeField]
	private RectTransform portraitMask;

	[SerializeField]
	private CanvasGroup infoPanel;

	[SerializeField]
	private TMP_Text infoText;

	[SerializeField]
	private Image portraitBottomDim;

	[SerializeField]
	private Image portraitOverlay;

	[SerializeField]
	private RectTransform overviewSectionRectTransform;

	private float overviewSectionRectTransformHeight;

	[SerializeField]
	private ScrollRect infoPanelScrollRect;

	[SerializeField]
	private float portraitMaskHeightOverview;

	[SerializeField]
	private float portraitMaskHeightInfo;

	private Sequence currentSequence;

	private void OnValidate()
	{
	}

	private void Awake()
	{
	}

	private void GetAutomaticReferences()
	{
	}

	public void ShowInfoOrOverview(bool showInfo)
	{
	}

	public void ShowInfo()
	{
	}

	public void ShowOverview()
	{
	}

	public void ChangedSkill()
	{
	}
}

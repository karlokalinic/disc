using System;
using System.Collections;
using Sunshine;
using Sunshine.Metric;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class HealingButton : MonoBehaviour, IPointerClickHandler, IEventSystemHandler, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
{
	[Serializable]
	private class HealingButtonState
	{
		[SerializeField]
		private Color buttonColor;

		[SerializeField]
		private Color textColor;

		[SerializeField]
		private Color lineColor;

		[SerializeField]
		private Color pipsColor;

		public void Apply(HealingButton healingButton)
		{
		}

		public void ApplyLerp(HealingButton healingButton, float value)
		{
		}
	}

	public const string HEAL_DAMAGE_ONE_SND = "aerosol";

	public const string HEAL_MORALE_ONE_SND = "magnesium";

	public const string SOUND_CATEGORY_NAME = "medpack";

	[SerializeField]
	private Image healingImage;

	[SerializeField]
	private TextMeshProUGUI chargesText;

	[SerializeField]
	private Image lineImage;

	[SerializeField]
	private SegmentIndicator segmentIndicator;

	[SerializeField]
	private SkillType healingPoolType;

	[SerializeField]
	private HealingButtonState normal;

	[SerializeField]
	private HealingButtonState hovered;

	[SerializeField]
	private HealingButtonState hoveredNonInteractable;

	[SerializeField]
	private HealingButtonState nonInteractable;

	[SerializeField]
	private HealingButtonState pressed;

	[SerializeField]
	private float healPredictDelay;

	private bool isInteractable;

	private bool isHovered;

	private bool isPressed;

	private float lastHealTime;

	private TooltipSource tooltipSource;

	private int animationIterations;

	private bool isAnimating;

	public int Charges { get; private set; }

	public SkillType HealingPoolType => default(SkillType);

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}

	public void OnPointerClick(PointerEventData eventData)
	{
	}

	public void AnimateButton()
	{
	}

	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	public void OnPointerExit(PointerEventData eventData)
	{
	}

	public void OnPointerDown(PointerEventData eventData)
	{
	}

	public void OnPointerUp(PointerEventData eventData)
	{
	}

	public void ShowHealPrediction(int amount)
	{
	}

	public void ShowDamagePrediction(int amount)
	{
	}

	public void HidePrediction()
	{
	}

	private void Refresh()
	{
	}

	private void RefreshCharges()
	{
	}

	private void RefreshInteractibility()
	{
	}

	private void RefreshChargesText()
	{
	}

	private void RefreshVisuals()
	{
	}

	private void DisplayNonInteractable()
	{
	}

	private void DisplayPressed()
	{
	}

	private void DisplayHovered()
	{
	}

	private void DisplayHoveredNonInteractable()
	{
	}

	private void DisplayNormal()
	{
	}

	private bool CanApplyHeal()
	{
		return false;
	}

	private void ApplyHeal()
	{
	}

	private void PlayFailtureSound()
	{
	}

	private void PlaySuccessSound(string sound)
	{
	}

	private IEnumerator DelayedRefreshCoroutine()
	{
		return null;
	}

	private bool CanPredictHeal()
	{
		return false;
	}

	private void OnWorldStarted()
	{
	}

	private void OnValueChanged()
	{
	}

	private void OnCharacterCreated()
	{
	}

	private void OnExistentialCrisisStarted()
	{
	}

	private void OnExistentialCrisisFinished()
	{
	}

	private IEnumerator PostNotificationAnimation()
	{
		return null;
	}
}

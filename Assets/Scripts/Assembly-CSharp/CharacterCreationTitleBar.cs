using LocalizationCustomSystem;
using TMPro;
using UnityEngine;

public class CharacterCreationTitleBar : MonoBehaviour
{
	public TextMeshProUGUI text;

	public RectTransform background;

	public SegmentIndicator abilityPips;

	public float pipWidth;

	public float paddingWidth;

	[SerializeField]
	private GameObject hardcoreIcon;

	[SerializeField]
	private float textTweenDuration;

	[SerializeField]
	private float backgroundTweenDuration;

	public TranslationTestableFloat AdjustAbilitiesWidth;

	public TranslationTestableFloat SetSkillWidth;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void UpdateData()
	{
	}

	private void SetAdjustTitle()
	{
	}

	private void SetSkillTitle()
	{
	}

	public void SetAbilityPipsValue(int value)
	{
	}
}

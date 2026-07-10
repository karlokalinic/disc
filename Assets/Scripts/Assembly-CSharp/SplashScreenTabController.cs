using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SplashScreenTabController : MonoBehaviour
{
	private const float ANIMATION_DURATION = 0.27f;

	[SerializeField]
	private Button detailsButton;

	[SerializeField]
	private Button bonusButton;

	[SerializeField]
	private RectTransform detailsRect;

	[SerializeField]
	private RectTransform bonusRect;

	[SerializeField]
	private TextMeshProUGUI detailsButtonText;

	[SerializeField]
	private TextMeshProUGUI bonusButtonText;

	[SerializeField]
	private Image tabBackground;

	[SerializeField]
	private Color activeTextCol;

	[SerializeField]
	private Color disabledTextCol;

	private Sequence sequence;

	private bool isBonusVisible;

	public bool IsBonusVisible => false;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void SwitchTabs()
	{
	}

	private void SwitchToDetails()
	{
	}

	private void SwitchToBonus()
	{
	}

	private void PrepareSequence()
	{
	}

	private void AnimateToTarget(RectTransform target, bool immediate = false)
	{
	}
}

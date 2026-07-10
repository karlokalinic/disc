using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class FlipClock : MonoBehaviour
{
	[SerializeField]
	private Animator animator;

	[SerializeField]
	private TextMeshProUGUI topText;

	[SerializeField]
	private TextMeshProUGUI topFallingText;

	[SerializeField]
	private TextMeshProUGUI bottomText;

	[SerializeField]
	private TextMeshProUGUI bottomFallingText;

	[SerializeField]
	private float defaultAnimationSpeed;

	[SerializeField]
	private bool applyRTL;

	public bool ToUpper;

	private string currentStringValue;

	private string newStringValue;

	private string pendingValue;

	private float currentAnimationSpeed;

	private bool isAnimating;

	private string hiddenStringValue;

	private Coroutine suspendAnimatorCoroutine;

	private static readonly int[] IdleStates;

	private bool IsHidden => false;

	public event Action ValueChangeAnimationFinished
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

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	public void UpdateFlipText(string newText)
	{
	}

	public void SetColor(Color color)
	{
	}

	public void UpdateTextFields(string newText, bool isRight2Left)
	{
	}

	public void Clear()
	{
	}

	public void ToggleVisibility()
	{
	}

	public void Show()
	{
	}

	public void Hide()
	{
	}

	public void SetToTopTextAndShow()
	{
	}

	public void AnimateToString(string newValue, float animationSpeed = -1f)
	{
	}

	private void DoAnimateToString(string newValue, float animationSpeed = -1f)
	{
	}

	public void OnValueChangeAnimationFinished()
	{
	}

	private void ExecuteSuspendAnimator()
	{
	}

	private void UpdateAnimation()
	{
	}

	private void UpdateTextFields()
	{
	}

	private void RestartAnimation()
	{
	}
}

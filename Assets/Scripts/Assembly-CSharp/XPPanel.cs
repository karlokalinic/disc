using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class XPPanel : MonoBehaviour
{
	[SerializeField]
	private SkillPointField skillPointField;

	[SerializeField]
	private TextMeshProUGUI panelText;

	[SerializeField]
	private HorizontalLayoutGroup segmentsLayout;

	[SerializeField]
	private VerticalLayoutGroup indicatorsLayout;

	[SerializeField]
	private TextMeshProUGUI skillPointsText;

	[SerializeField]
	private Image image;

	[SerializeField]
	private float tweenFactor;

	[SerializeField]
	private float tweenMax;

	[SerializeField]
	private float tweenMin;

	private static int targetValue;

	private static float currentValue;

	private static int currentLevel;

	private static int CurrentLevelXpMin => 0;

	private static int NextLevelXpCost => 0;

	public static bool IsTweening { get; private set; }

	public bool NeedsValueRefresh { get; private set; }

	public bool NeedsVisualRefresh { get; private set; }

	public SkillPointField SkillPointField => null;

	public static event Action<int> OnUILevelUp
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

	public static event Action OnTweenEnd
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

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Update()
	{
	}

	private void LateUpdate()
	{
	}

	public void SetValue(int newValue)
	{
	}

	public void InitData()
	{
	}

	public void UpdateData()
	{
	}

	private void UpdateLevel()
	{
	}

	public void RefreshVisuals()
	{
	}

	private void UpdateCurrentValue()
	{
	}

	private void HandleTweenEnd()
	{
	}

	private void OnWorldStarted()
	{
	}
}

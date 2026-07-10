using System;
using System.Runtime.CompilerServices;
using Sunshine.Metric;
using UnityEngine;
using UnityEngine.UI;

public class StatusNotification : MonoBehaviour, IGenericTooltipDataProvider
{
	[SerializeField]
	private Animator animator;

	[SerializeField]
	private Image icon;

	[SerializeField]
	private Image outline;

	[SerializeField]
	private Sprite alcoholIcon;

	[SerializeField]
	private Sprite alcohoOutline;

	[SerializeField]
	private Sprite smokeIcon;

	[SerializeField]
	private Sprite smokeOutline;

	[SerializeField]
	private Sprite drugsIcon;

	[SerializeField]
	private Sprite drugsOutline;

	[SerializeField]
	private Sprite drugsIconPurple;

	[SerializeField]
	private Sprite drugsOutlinePurple;

	private bool isEnabled;

	private static readonly int EnabledState;

	private static readonly int DisabledState;

	public InventoryItem SourceItem { get; private set; }

	public CharacterEffect Effect { get; private set; }

	public event Action<StatusNotification> OnDisabled
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

	public void ShowEffect(InventoryItem item, CharacterEffect effect)
	{
	}

	public void SetEnabled(bool isEnabled)
	{
	}

	public void NotifyDisabledAnimationEvent()
	{
	}

	private void Refresh()
	{
	}

	private void RefreshSprites()
	{
	}

	public GenericTooltipData GetTooltipData()
	{
		return null;
	}
}

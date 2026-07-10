using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HudMenuButton : MonoBehaviour
{
	private static List<HudButtonState> NO_NOTIFICATION_STATES;

	private const string NotifyAnimName = "NotifyJump";

	[SerializeField]
	private Animator anim;

	[SerializeField]
	private Image image;

	[SerializeField]
	private Sprite buttonActiveSprite;

	[SerializeField]
	private Sprite buttonNormalSprite;

	private bool showAnimOnNews;

	private HudButtonState _state;

	private Button hudButtonComponent;

	private ColorBlock buttonColors;

	private Color activeColor;

	private Color normalColor;

	private Color newsColor;

	public Notifier notifier;

	public Func<bool> GetFreshCountOnButtonEnabled;

	public Func<bool> CanBeInteractable;

	public bool NotifyNew
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public HudButtonState State
	{
		get
		{
			return default(HudButtonState);
		}
		set
		{
		}
	}

	private void OnEnable()
	{
	}

	private void Start()
	{
	}

	private void RefreshSprite()
	{
	}

	public void OnViewOpen()
	{
	}

	public void OnViewClose()
	{
	}

	public void ShowNotifAnimOnNextNews()
	{
	}

	public void PlayAnimation(float normalizedTime = 0f)
	{
	}

	private void CheckCountOnEnable()
	{
	}

	public void RefreshStyle()
	{
	}
}

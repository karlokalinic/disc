using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using Voidforge;

public class HudController : SingletonComponent<HudController>
{
	protected bool _dirty;

	protected bool _dirty2;

	public PartyVisualizer partyVisualizer;

	public Image partyStatsBG;

	public AnimationCurve appearCurve;

	public AnimationCurve disappearCurve;

	private UITweenCanvasgroupAlpha canvasTween;

	public UnityEvent OnHealthNotificationRecieved;

	public UnityEvent OnVolitionNotificationRecieved;

	protected override void Awake()
	{
	}

	public void Show()
	{
	}

	public void Hide()
	{
	}

	public void OnEnable()
	{
	}

	public void OnDisable()
	{
	}

	private void DisableOnEnd()
	{
	}

	public void RefreshAll()
	{
	}

	public void Update()
	{
	}
}

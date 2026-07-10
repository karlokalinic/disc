using System.Collections;
using TMPro;
using Voidforge;

public class ShowTime : VoidElement
{
	protected ComponentRef<TextMeshProUGUI> text;

	private int lastDayMinutes;

	private string visualTime;

	private string desiredTime;

	private bool changeover;

	private bool removal;

	public void OnEnable()
	{
	}

	public void OnDisable()
	{
	}

	private string GetTimeString()
	{
		return null;
	}

	private void UpdateTime()
	{
	}

	public void Update()
	{
	}

	private IEnumerator DelayedTimeChange(int daytime)
	{
		return null;
	}

	private IEnumerator DelayedHideClock()
	{
		return null;
	}
}

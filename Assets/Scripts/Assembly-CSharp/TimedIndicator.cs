using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class TimedIndicator : MonoBehaviour
{
	public float time;

	public float elapsedTime;

	private Image image;

	private bool manualControl;

	public static TimedIndicator ConvertToTimedIndicator(Image original, Sprite sprite, Color color, bool manualControl)
	{
		return null;
	}

	public static TimedIndicator ConvertToTimedIndicator(Image original, Sprite sprite, Color color, float timer)
	{
		return null;
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void SetFillAmount(float fillAmount)
	{
	}

	public IEnumerator ShrinkComponent()
	{
		return null;
	}
}

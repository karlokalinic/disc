using System.Collections;
using UnityEngine;

public class FanRotatorTemp : MonoBehaviour
{
	public float degreesPerSecond;

	public float degreeOfAction;

	public float lengthOfAction;

	public Transform tie;

	public AnimationCurve stopFanAnimation;

	public float fanStopLength;

	private float fanStopTime;

	private float startingDegree;

	private bool fanOn;

	private bool fanStopped;

	public float secondsToWait => 0f;

	public void OnEnable()
	{
	}

	private void Update()
	{
	}

	public void FanOff()
	{
	}

	private IEnumerator FanOffCorrectPosition()
	{
		return null;
	}

	public void FanOn()
	{
	}
}

using UnityEngine;
using UnityEngine.Events;

public class RollOut : MonoBehaviour
{
	public AnimationCurve ease;

	public float startWidth;

	public float endWidth;

	public UnityEvent onFinish;

	private RectTransform rt;

	private bool isPlaying;

	private float endTime;

	private float currentTime;

	public bool IsPlaying => false;

	private void OnEnable()
	{
	}

	public void Play()
	{
	}

	public void Stop()
	{
	}

	public void SetSize(float t)
	{
	}

	private void Reset()
	{
	}

	public void Update()
	{
	}
}

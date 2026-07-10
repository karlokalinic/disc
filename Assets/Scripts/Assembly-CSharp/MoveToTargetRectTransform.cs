using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class MoveToTargetRectTransform : MonoBehaviour
{
	public Vector3 startPosition;

	public Vector3 targetPosition;

	public float transitionTime;

	public AnimationCurve curve;

	private float transitionState;

	private RectTransform rt;

	public event Action DoneEvent
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

	public static bool IsTransitioning(GameObject g)
	{
		return false;
	}

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void Done()
	{
	}

	public void Reset()
	{
	}

	private void Update()
	{
	}
}

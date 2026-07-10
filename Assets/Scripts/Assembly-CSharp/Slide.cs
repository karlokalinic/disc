using System;
using UnityEngine;

public class Slide : MonoBehaviour
{
	private RectTransform rt;

	private RectTransform loadedTransform;

	private SlidePosition lastMovement;

	public Action OnTransformLoaded;

	public Vector3 LoadPos => default(Vector3);

	public Vector2 BotPos => default(Vector2);

	public Vector3 TopPos => default(Vector3);

	public void Awake()
	{
	}

	public void Init(Transform target)
	{
	}

	public void Land(Transform target)
	{
	}

	public void Rise(Transform target)
	{
	}

	public void Lift()
	{
	}

	public void Sink()
	{
	}

	public void Load(Transform target)
	{
	}

	public void Banish()
	{
	}

	private void Load(RectTransform target)
	{
	}

	public bool IsLoaded(Transform target)
	{
		return false;
	}

	public void FadeIn()
	{
	}

	public void FadeOut()
	{
	}

	public bool IsHidden()
	{
		return false;
	}

	private void Load2Top(RectTransform target)
	{
	}

	private void Load2Bot(RectTransform target)
	{
	}

	private void Bot2Load(RectTransform target)
	{
	}

	private void Top2Load(RectTransform target)
	{
	}

	private void SetSize(RectTransform target, Vector2 size)
	{
	}

	private void AlphaIn(RectTransform target)
	{
	}

	private void AlphaOut(RectTransform target)
	{
	}

	public float GetAlpha()
	{
		return 0f;
	}

	private void MoveToPosition(RectTransform target, Vector3 start, Vector3 end, bool endInteraction = false, Action OnMoveDone = null)
	{
	}

	private void TogglePosition()
	{
	}
}

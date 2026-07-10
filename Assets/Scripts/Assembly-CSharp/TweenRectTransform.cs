using System.Collections;
using UnityEngine;

public class TweenRectTransform : MonoBehaviour
{
	[SerializeField]
	private bool tweenLocalPos;

	[SerializeField]
	private float sizeOffset;

	public float DurationInSeconds;

	public AnimationCurve AnimationCurve;

	[HideInInspector]
	public RectTransform rectTransform;

	private Vector3 target;

	private float timePassed;

	private Vector3 startingPosition;

	private Vector3 targetPosition;

	private Vector3 startingSize;

	private Vector3 targetSize;

	private bool isMoving;

	private bool isResizing;

	private IEnumerator moveCoR;

	private IEnumerator resizeCoR;

	private void Awake()
	{
	}

	public void MoveAndResize(RectTransform targetRectTransform)
	{
	}

	public void Move(Transform targetTransform)
	{
	}

	public void Resize(RectTransform targetRectTransform)
	{
	}

	public void ForceMoveAndResize(RectTransform targetRectTransform)
	{
	}

	public void ForceMove(Transform targetTransform)
	{
	}

	public void ForceResize(RectTransform targetRectTransform)
	{
	}

	public void Jump(Transform targetTransform)
	{
	}

	public void SetSize(RectTransform targetRectTransform)
	{
	}

	private IEnumerator AnimateMove()
	{
		return null;
	}

	private IEnumerator AnimateResize()
	{
		return null;
	}

	public void Stop()
	{
	}
}

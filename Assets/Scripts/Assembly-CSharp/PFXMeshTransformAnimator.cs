using System.Collections;
using UnityEngine;

public class PFXMeshTransformAnimator : PFXAnimatorBase
{
	public TransformStruct from;

	public TransformStruct to;

	public AnimationCurve easing;

	private TransformStruct actualFrom;

	private TransformStruct actualTo;

	public bool worldSpace;

	public bool disableOnStop;

	private Renderer[] r;

	private Light[] l;

	private Coroutine cor;

	public Transform originalParent;

	private void Awake()
	{
	}

	private void OnValidate()
	{
	}

	public override void Trigger()
	{
	}

	public override void ResetPFX()
	{
	}

	public override void Stop()
	{
	}

	public override void UpdateFX()
	{
	}

	public override IEnumerator EvaluateCurve()
	{
		return null;
	}

	private void ChildRenderersActive(bool are)
	{
	}

	public void SetFrom()
	{
	}

	public void SetTo()
	{
	}

	public void GetFrom()
	{
	}

	public void GetTo()
	{
	}
}

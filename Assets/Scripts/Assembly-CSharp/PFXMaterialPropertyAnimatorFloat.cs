using System.Collections;
using UnityEngine;

public class PFXMaterialPropertyAnimatorFloat : PFXAnimatorBase
{
	public AnimationCurve curve;

	public int materialIndex;

	public string propertyName;

	private Renderer r;

	private Coroutine cor;

	private void Awake()
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
}

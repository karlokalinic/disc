using System.Collections;
using UnityEngine;

public class PFXAnimatorBase : PFX
{
	public float duration;

	public float delay;

	public bool resetOnStop;

	protected double fxStartTime;

	private Coroutine cor;

	protected float evalVal;

	public override void Trigger()
	{
	}

	public virtual void Stop()
	{
	}

	public override void ResetPFX()
	{
	}

	public virtual IEnumerator EvaluateCurve()
	{
		return null;
	}

	public override void UpdateFX()
	{
	}
}

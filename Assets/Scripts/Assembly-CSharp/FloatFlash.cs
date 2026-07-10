using System.Collections;
using UnityEngine.Events;
using Voidforge;

public class FloatFlash : VoidElement
{
	public UnityEvent onFinish;

	protected ComponentRef<RollOut> rollout;

	public void Play()
	{
	}

	public IEnumerator DelayPlay()
	{
		return null;
	}

	public void CheckDone()
	{
	}
}

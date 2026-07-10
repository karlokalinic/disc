using System.Collections;
using UnityEngine;

public class InitializeAnimationOnAwake : MonoBehaviour
{
	private RuntimeAnimatorController AnimatorController;

	private string AnimationTrigger;

	private Coroutine waitAndSetAnimator;

	public void SetAnimationValues(RuntimeAnimatorController animatorController, string animationTrigger)
	{
	}

	public void OnEnable()
	{
	}

	private void StopIfActive()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}

	private IEnumerator WaitAndSetAnimator()
	{
		return null;
	}
}

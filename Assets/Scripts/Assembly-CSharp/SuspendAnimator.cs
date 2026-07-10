using System.Collections;
using UnityEngine;

public class SuspendAnimator : MonoBehaviour
{
	public enum Type
	{
		SuspendAfterPlay = 0,
		SuspendIdle = 1,
		SuspendEitherAfterTransition = 2,
		SuspendDisabledAfterTransition = 3
	}

	public struct Params
	{
		public Type type;

		public Animator animator;

		public int enabledState;

		public int disabledState;

		public int[] idleStates;

		public bool enable;
	}

	public Type type;

	public string enabledStateName;

	public string disabledStateName;

	public string[] idleStateNames;

	public bool enable;

	private Animator animator;

	private Params param;

	private Coroutine coroutine;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	public IEnumerator Execute()
	{
		return null;
	}

	public static IEnumerator Execute(Params param)
	{
		return null;
	}
}

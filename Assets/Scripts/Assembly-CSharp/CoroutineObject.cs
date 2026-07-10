using System;
using System.Collections;
using UnityEngine;

public class CoroutineObject : MonoBehaviour
{
	private static CoroutineObject instance;

	public static CoroutineObject Instance => null;

	public static IEnumerator WaitForFrame(Action onFinish)
	{
		return null;
	}

	public static IEnumerator WaitForTime(float duration, Action onFinish)
	{
		return null;
	}
}

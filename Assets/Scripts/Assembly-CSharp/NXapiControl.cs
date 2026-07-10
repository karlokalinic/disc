using System;
using UnityEngine;

[DisallowMultipleComponent]
public class NXapiControl : MonoBehaviour
{
	public enum OperationMode
	{
		Handheld = 0,
		Docked = 1
	}

	public static Action<OperationMode> OnChangedOperationMode;

	public static bool IsInHandheldMode()
	{
		return false;
	}
}

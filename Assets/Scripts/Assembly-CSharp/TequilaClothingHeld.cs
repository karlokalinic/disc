using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;

public static class TequilaClothingHeld
{
	private static string VISUAL_HOLD_RIGHT_PROP_NAME;

	private static string VISUAL_HOLD_LEFT_PROP_NAME;

	public static Dictionary<string, AsyncOperationHandle<GameObject>> LeftItemsHandles;

	public static Dictionary<string, AsyncOperationHandle<GameObject>> RightItemsHandles;

	public static void VisualHold()
	{
	}

	public static void VisualHoldRight(Action onHoldAction = null)
	{
	}

	public static void VisualHoldLeft(Action onHoldAction = null)
	{
	}

	public static void HoldRight(string itemName, bool animateHand = true, Action loadedAction = null)
	{
	}

	public static void HoldLeft(string itemName, bool animateHand = true, Action loadedAction = null)
	{
	}

	private static void OnHoldRightItemLoaded(AsyncOperationHandle<GameObject> itemHandle, bool animateHand)
	{
	}

	private static void OnHoldLeftItemLoaded(AsyncOperationHandle<GameObject> itemHandle, bool animateHand)
	{
	}

	private static void HoldRightPhysical(Transform equipment, bool animateHand)
	{
	}

	private static void HoldLeftPhysical(Transform equipment, bool animateHand)
	{
	}

	public static void VisualUnhold()
	{
	}

	public static void VisualUnholdRight()
	{
	}

	public static void VisualUnholdLeft()
	{
	}

	public static void UnholdRight(string item, bool animateHand = true)
	{
	}

	public static void UnholdLeft(string item, bool animateHand = true)
	{
	}

	private static void UnholdRightPhysical(Transform equipment, bool animateHand = true)
	{
	}

	private static void UnholdLeftPhysical(Transform equipment, bool animateHand = true)
	{
	}

	public static void PropHoldRight(string item)
	{
	}

	public static void PropHoldLeft(string item)
	{
	}

	public static void PropUnhold()
	{
	}

	public static void PropUnholdRight()
	{
	}

	public static void PropUnholdLeft()
	{
	}

	public static void RestoreActualHeld()
	{
	}
}

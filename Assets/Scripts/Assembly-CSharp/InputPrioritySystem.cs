using System;
using System.Collections.Generic;
using InControl;
using UnityEngine;

public class InputPrioritySystem : MonoBehaviour
{
	public enum EVENT_PRIORITY
	{
		MINIMUM = 0,
		LOW = 1,
		MEDIUM = 10,
		HIGH = 100,
		MAXIMUM = 1000
	}

	public enum Trigger
	{
		Down = 0,
		Held = 1,
		Up = 2
	}

	private struct PlayerActionTriggerPair
	{
		public PlayerAction Action;

		public Trigger Trigger;
	}

	private static InputPrioritySystem singleton;

	private static bool areInputsConsumed;

	private Dictionary<PlayerActionTriggerPair, SortedList<int, Action>> subscribedPlayerActions;

	private List<KeyValuePair<PlayerActionTriggerPair, SortedList<int, Action>>> subscribedPlayerActionsCopy;

	public static bool AreInputsConsumed => false;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	public static void ConsumeAllInputs(PlayerAction action = null)
	{
	}

	public static void ReleaseAllInputs()
	{
	}

	private static void IgnoreInputAction()
	{
	}

	public static void SubscribeInputAction(PlayerAction playerAction, Trigger trigger, Action method, int priority)
	{
	}

	public static void UnsubscribeInputAction(PlayerAction playerAction, Trigger trigger, Action method)
	{
	}
}

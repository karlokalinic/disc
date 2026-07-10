using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class KeyboardInputManager : MonoBehaviour
{
	private static KeyboardInputManager singleton;

	private Dictionary<KeyCode, UnityEvent> keyEventContainer;

	private static KeyboardInputManager Singleton => null;

	private static void SetThisAsSingleton(KeyboardInputManager keyboardInputManager)
	{
	}

	private void Awake()
	{
	}

	private void Update()
	{
	}

	public static void RegisterKeyDownAction(KeyCode key, UnityAction actionOnKeyDown)
	{
	}

	public static void RemoveKeyDownAction(KeyCode key, UnityAction actionOnKeyDown)
	{
	}

	public static bool IsSubmitKeyDown()
	{
		return false;
	}
}

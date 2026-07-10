using System;
using InControl;
using UnityEngine;

public class InputHotplugHandler : MonoBehaviour
{
	public enum InputDeviceType : uint
	{
		None = 0u,
		Mouse = 1u,
		Keyboard = 2u,
		PS4Controller = 3u,
		PS5Controller = 4u,
		XboxController = 5u,
		StadiaController = 6u,
		NintendoProController = 7u,
		XboxSeriesController = 8u,
		NintendoJoyConController = 9u,
		SteamDeck = 10u
	}

	private string deviceName;

	public static bool ForceEventTrigger;

	private InputDeviceClass lastInputDeviceUsed;

	private InputDeviceType prevDeviceType;

	private InputDeviceType currDeviceType;

	public static Action<string, InputDeviceType> OnDeviceChanged;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnDeviceAttached(InputDevice device)
	{
	}

	private void OnDeviceDetached(InputDevice device)
	{
	}

	private void OnActiveDeviceChanged(InputDevice device)
	{
	}

	private void LateUpdate()
	{
	}

	public static InputDeviceType GetControllerTypeFromString(string name)
	{
		return default(InputDeviceType);
	}
}

using System.Collections;
using System.Collections.Generic;
using InControl;
using UnityEngine;

public class CrossPlatformInputManager : MonoBehaviour
{
	public enum ButtonsState
	{
		hidden = 0,
		ps4 = 1,
		xboxone = 2,
		nx = 3,
		stadia = 4,
		pc = 5,
		ps5 = 6,
		xboxseries = 7,
		nxpro = 8,
		steamDeck = 9
	}

	private class WaitForSecondsRT : CustomYieldInstruction
	{
		private float m_Time;

		public override bool keepWaiting => false;

		public WaitForSecondsRT(float aWaitTime)
		{
		}

		public WaitForSecondsRT NewTime(float aTime)
		{
			return null;
		}
	}

	public static CrossPlatformInputManager mCPIM;

	public bool hasGamepad;

	public bool isLoading;

	public InputDevice inputDevice;

	public MyCharacterActions InputActions;

	public CharacterAnalogueControl AnalogueCharPos;

	public bool analogueControl;

	public bool analogueViewControl;

	public Dictionary<int, ButtonsIconsController> ButtonsList;

	private KeyboardLayoutBindings KBLayoutBindings;

	private string saveData;

	public ButtonsState currentButtonsState;

	public ButtonsState lastButtonsState;

	private ButtonsState lastSelectedButtonState;

	public bool IsGamePadCurrentlyUsed()
	{
		return false;
	}

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

	private IEnumerator CheckGamePadUnscaled()
	{
		return null;
	}

	public void CheckGamePad()
	{
	}

	public void RumbleController(float leftMotor, float rightMotor, float time)
	{
	}

	private void ResetRumbleController()
	{
	}

	public void UpdateButtonIcons()
	{
	}

	public void ActivateInputActions(bool flag)
	{
	}

	public void UpdateDefaultBindings(string deviceName)
	{
	}

	public void CreateDefaultBindings(string deviceName, KeyboardLayoutBindings.KeyboardLayout kbLayout, bool forceKBLayoutChange = false)
	{
	}

	public void SaveDefaultsBindings()
	{
	}

	public void LoadDefaultsBindings()
	{
	}

	public void SaveBindings()
	{
	}

	public void LoadBindings()
	{
	}
}

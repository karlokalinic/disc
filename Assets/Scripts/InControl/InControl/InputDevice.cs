using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using UnityEngine;

namespace InControl
{
	public class InputDevice
	{
		protected struct AnalogSnapshotEntry
		{
			public float value;

			public float maxValue;

			public float minValue;

			public void TrackMinMaxValue(float currentValue)
			{
			}
		}

		public static readonly InputDevice Null;

		private readonly List<InputControl> controls;

		public bool Passive;

		private InputControl cachedLeftStickUp;

		private InputControl cachedLeftStickDown;

		private InputControl cachedLeftStickLeft;

		private InputControl cachedLeftStickRight;

		private InputControl cachedRightStickUp;

		private InputControl cachedRightStickDown;

		private InputControl cachedRightStickLeft;

		private InputControl cachedRightStickRight;

		private InputControl cachedDPadUp;

		private InputControl cachedDPadDown;

		private InputControl cachedDPadLeft;

		private InputControl cachedDPadRight;

		private InputControl cachedAction1;

		private InputControl cachedAction2;

		private InputControl cachedAction3;

		private InputControl cachedAction4;

		private InputControl cachedLeftTrigger;

		private InputControl cachedRightTrigger;

		private InputControl cachedLeftBumper;

		private InputControl cachedRightBumper;

		private InputControl cachedLeftStickButton;

		private InputControl cachedRightStickButton;

		private InputControl cachedLeftStickX;

		private InputControl cachedLeftStickY;

		private InputControl cachedRightStickX;

		private InputControl cachedRightStickY;

		private InputControl cachedDPadX;

		private InputControl cachedDPadY;

		private InputControl cachedCommand;

		public string Name { get; protected set; }

		public string Meta { get; protected set; }

		public int SortOrder { get; protected set; }

		public InputDeviceClass DeviceClass { get; protected set; }

		public InputDeviceStyle DeviceStyle { get; protected set; }

		public Guid GUID { get; private set; }

		public ulong LastInputTick { get; private set; }

		public bool IsActive { get; private set; }

		public bool IsAttached { get; private set; }

		protected bool RawSticks { get; private set; }

		public ReadOnlyCollection<InputControl> Controls { get; protected set; }

		protected InputControl[] ControlsByTarget { get; private set; }

		public TwoAxisInputControl LeftStick { get; private set; }

		public TwoAxisInputControl RightStick { get; private set; }

		public TwoAxisInputControl DPad { get; private set; }

		protected AnalogSnapshotEntry[] AnalogSnapshot { get; set; }

		public InputControl Item => null;

		public virtual bool IsSupportedOnThisPlatform => false;

		public virtual bool IsKnown => false;

		public bool IsUnknown => false;

		[Obsolete]
		public bool MenuIsPressed => false;

		[Obsolete]
		public bool MenuWasPressed => false;

		[Obsolete]
		public bool MenuWasReleased => false;

		public bool CommandIsPressed => false;

		public bool CommandWasPressed => false;

		public bool CommandWasReleased => false;

		public InputControl AnyButton => null;

		public bool AnyButtonIsPressed => false;

		public bool AnyButtonWasPressed => false;

		public bool AnyButtonWasReleased => false;

		public TwoAxisInputControl Direction => null;

		public InputControl LeftStickUp => null;

		public InputControl LeftStickDown => null;

		public InputControl LeftStickLeft => null;

		public InputControl LeftStickRight => null;

		public InputControl RightStickUp => null;

		public InputControl RightStickDown => null;

		public InputControl RightStickLeft => null;

		public InputControl RightStickRight => null;

		public InputControl DPadUp => null;

		public InputControl DPadDown => null;

		public InputControl DPadLeft => null;

		public InputControl DPadRight => null;

		public InputControl Action1 => null;

		public InputControl Action2 => null;

		public InputControl Action3 => null;

		public InputControl Action4 => null;

		public InputControl LeftTrigger => null;

		public InputControl RightTrigger => null;

		public InputControl LeftBumper => null;

		public InputControl RightBumper => null;

		public InputControl LeftStickButton => null;

		public InputControl RightStickButton => null;

		public InputControl LeftStickX => null;

		public InputControl LeftStickY => null;

		public InputControl RightStickX => null;

		public InputControl RightStickY => null;

		public InputControl DPadX => null;

		public InputControl DPadY => null;

		public InputControl Command => null;

		public virtual int NumUnknownAnalogs => 0;

		public virtual int NumUnknownButtons => 0;

		public InputDevice()
		{
		}

		public InputDevice(string name)
		{
		}

		public InputDevice(string name, bool rawSticks)
		{
		}

		internal void OnAttached()
		{
		}

		internal void OnDetached()
		{
		}

		private void AddAliasControls()
		{
		}

		private void RemoveAliasControls()
		{
		}

		protected void ClearControls()
		{
		}

		public bool HasControl(InputControlType controlType)
		{
			return false;
		}

		public InputControl GetControl(InputControlType controlType)
		{
			return null;
		}

		public static InputControlType GetInputControlTypeByName(string inputControlName)
		{
			return default(InputControlType);
		}

		public InputControl GetControlByName(string controlName)
		{
			return null;
		}

		public InputControl AddControl(InputControlType controlType, string handle)
		{
			return null;
		}

		public InputControl AddControl(InputControlType controlType, string handle, float lowerDeadZone, float upperDeadZone)
		{
			return null;
		}

		private void RemoveControl(InputControlType controlType)
		{
		}

		public void ClearInputState()
		{
		}

		protected void UpdateWithState(InputControlType controlType, bool state, ulong updateTick, float deltaTime)
		{
		}

		protected void UpdateWithValue(InputControlType controlType, float value, ulong updateTick, float deltaTime)
		{
		}

		public void UpdateLeftStickWithValue(Vector2 value, ulong updateTick, float deltaTime)
		{
		}

		public void UpdateLeftStickWithRawValue(Vector2 value, ulong updateTick, float deltaTime)
		{
		}

		public void CommitLeftStick()
		{
		}

		public void UpdateRightStickWithValue(Vector2 value, ulong updateTick, float deltaTime)
		{
		}

		public void UpdateRightStickWithRawValue(Vector2 value, ulong updateTick, float deltaTime)
		{
		}

		public void CommitRightStick()
		{
		}

		public virtual void Update(ulong updateTick, float deltaTime)
		{
		}

		private void ProcessLeftStick(ulong updateTick, float deltaTime)
		{
		}

		private void ProcessRightStick(ulong updateTick, float deltaTime)
		{
		}

		private void ProcessDPad(ulong updateTick, float deltaTime)
		{
		}

		public void Commit(ulong updateTick, float deltaTime)
		{
		}

		public bool LastInputAfter(InputDevice device)
		{
			return false;
		}

		internal void RequestActivation()
		{
		}

		public virtual void Vibrate(float leftMotor, float rightMotor)
		{
		}

		public void Vibrate(float intensity)
		{
		}

		public void StopVibration()
		{
		}

		public virtual void SetLightColor(float red, float green, float blue)
		{
		}

		public void SetLightColor(Color color)
		{
		}

		public virtual void SetLightFlash(float flashOnDuration, float flashOffDuration)
		{
		}

		public void StopLightFlash()
		{
		}

		private void ExpireControlCache()
		{
		}

		public virtual bool ReadRawButtonState(int index)
		{
			return false;
		}

		public virtual float ReadRawAnalogValue(int index)
		{
			return 0f;
		}

		public void TakeSnapshot()
		{
		}

		public UnknownDeviceControl GetFirstPressedAnalog()
		{
			return default(UnknownDeviceControl);
		}

		public UnknownDeviceControl GetFirstPressedButton()
		{
			return default(UnknownDeviceControl);
		}
	}
}

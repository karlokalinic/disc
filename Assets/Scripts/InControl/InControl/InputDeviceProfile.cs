using System;
using System.Collections.Generic;
using UnityEngine;

namespace InControl
{
	[Serializable]
	[Preserve]
	public class InputDeviceProfile
	{
		private static readonly HashSet<Type> hiddenProfiles;

		[SerializeField]
		private InputDeviceProfileType profileType;

		[SerializeField]
		private string deviceName;

		[SerializeField]
		[TextArea]
		private string deviceNotes;

		[SerializeField]
		private InputDeviceClass deviceClass;

		[SerializeField]
		private InputDeviceStyle deviceStyle;

		[SerializeField]
		private float sensitivity;

		[SerializeField]
		private float lowerDeadZone;

		[SerializeField]
		private float upperDeadZone;

		[SerializeField]
		private string[] includePlatforms;

		[SerializeField]
		private string[] excludePlatforms;

		[SerializeField]
		private int minSystemBuildNumber;

		[SerializeField]
		private int maxSystemBuildNumber;

		[SerializeField]
		private VersionInfo minUnityVersion;

		[SerializeField]
		private VersionInfo maxUnityVersion;

		[SerializeField]
		private InputDeviceMatcher[] matchers;

		[SerializeField]
		private InputDeviceMatcher[] lastResortMatchers;

		[SerializeField]
		private InputControlMapping[] analogMappings;

		[SerializeField]
		private InputControlMapping[] buttonMappings;

		protected static readonly InputControlSource MenuKey;

		protected static readonly InputControlSource EscapeKey;

		public InputDeviceProfileType ProfileType
		{
			get
			{
				return default(InputDeviceProfileType);
			}
			protected set
			{
			}
		}

		public string DeviceName
		{
			get
			{
				return null;
			}
			protected set
			{
			}
		}

		public string DeviceNotes
		{
			get
			{
				return null;
			}
			protected set
			{
			}
		}

		public InputDeviceClass DeviceClass
		{
			get
			{
				return default(InputDeviceClass);
			}
			protected set
			{
			}
		}

		public InputDeviceStyle DeviceStyle
		{
			get
			{
				return default(InputDeviceStyle);
			}
			protected set
			{
			}
		}

		public float Sensitivity
		{
			get
			{
				return 0f;
			}
			protected set
			{
			}
		}

		public float LowerDeadZone
		{
			get
			{
				return 0f;
			}
			protected set
			{
			}
		}

		public float UpperDeadZone
		{
			get
			{
				return 0f;
			}
			protected set
			{
			}
		}

		public InputControlMapping[] AnalogMappings
		{
			get
			{
				return null;
			}
			protected set
			{
			}
		}

		public InputControlMapping[] ButtonMappings
		{
			get
			{
				return null;
			}
			protected set
			{
			}
		}

		public string[] IncludePlatforms
		{
			get
			{
				return null;
			}
			protected set
			{
			}
		}

		public string[] ExcludePlatforms
		{
			get
			{
				return null;
			}
			protected set
			{
			}
		}

		public int MinSystemBuildNumber
		{
			get
			{
				return 0;
			}
			protected set
			{
			}
		}

		public int MaxSystemBuildNumber
		{
			get
			{
				return 0;
			}
			protected set
			{
			}
		}

		public VersionInfo MinUnityVersion
		{
			get
			{
				return default(VersionInfo);
			}
			protected set
			{
			}
		}

		public VersionInfo MaxUnityVersion
		{
			get
			{
				return default(VersionInfo);
			}
			protected set
			{
			}
		}

		public InputDeviceMatcher[] Matchers
		{
			get
			{
				return null;
			}
			protected set
			{
			}
		}

		public InputDeviceMatcher[] LastResortMatchers
		{
			get
			{
				return null;
			}
			protected set
			{
			}
		}

		public bool IsSupportedOnThisPlatform => false;

		public bool IsHidden => false;

		public bool IsNotHidden => false;

		public int AnalogCount => 0;

		public int ButtonCount => 0;

		public static InputDeviceProfile CreateInstanceOfType(Type type)
		{
			return null;
		}

		public static InputDeviceProfile CreateInstanceOfType(string typeName)
		{
			return null;
		}

		public virtual void Define()
		{
		}

		public bool Matches(InputDeviceInfo deviceInfo)
		{
			return false;
		}

		public bool LastResortMatches(InputDeviceInfo deviceInfo)
		{
			return false;
		}

		public bool Matches(InputDeviceInfo deviceInfo, InputDeviceMatcher[] matchers)
		{
			return false;
		}

		public static void Hide(Type type)
		{
		}

		protected static InputControlSource Button(int index)
		{
			return default(InputControlSource);
		}

		protected static InputControlSource Analog(int index)
		{
			return default(InputControlSource);
		}

		protected static InputControlMapping LeftStickLeftMapping(int analog)
		{
			return null;
		}

		protected static InputControlMapping LeftStickRightMapping(int analog)
		{
			return null;
		}

		protected static InputControlMapping LeftStickUpMapping(int analog)
		{
			return null;
		}

		protected static InputControlMapping LeftStickDownMapping(int analog)
		{
			return null;
		}

		protected static InputControlMapping LeftStickUpMapping2(int analog)
		{
			return null;
		}

		protected static InputControlMapping LeftStickDownMapping2(int analog)
		{
			return null;
		}

		protected static InputControlMapping RightStickLeftMapping(int analog)
		{
			return null;
		}

		protected static InputControlMapping RightStickRightMapping(int analog)
		{
			return null;
		}

		protected static InputControlMapping RightStickUpMapping(int analog)
		{
			return null;
		}

		protected static InputControlMapping RightStickDownMapping(int analog)
		{
			return null;
		}

		protected static InputControlMapping RightStickUpMapping2(int analog)
		{
			return null;
		}

		protected static InputControlMapping RightStickDownMapping2(int analog)
		{
			return null;
		}

		protected static InputControlMapping LeftTriggerMapping(int analog, string name = "Left Trigger")
		{
			return null;
		}

		protected static InputControlMapping RightTriggerMapping(int analog, string name = "Right Trigger")
		{
			return null;
		}

		protected static InputControlMapping DPadLeftMapping(int analog)
		{
			return null;
		}

		protected static InputControlMapping DPadRightMapping(int analog)
		{
			return null;
		}

		protected static InputControlMapping DPadUpMapping(int analog)
		{
			return null;
		}

		protected static InputControlMapping DPadDownMapping(int analog)
		{
			return null;
		}

		protected static InputControlMapping DPadUpMapping2(int analog)
		{
			return null;
		}

		protected static InputControlMapping DPadDownMapping2(int analog)
		{
			return null;
		}
	}
}

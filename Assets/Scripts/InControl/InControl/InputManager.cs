using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;

namespace InControl
{
	public static class InputManager
	{
		public static readonly VersionInfo Version;

		public static bool NxPro;

		private static readonly List<InputDeviceManager> deviceManagers;

		private static readonly Dictionary<Type, InputDeviceManager> deviceManagerTable;

		private static readonly List<InputDevice> devices;

		private static InputDevice activeDevice;

		private static readonly List<InputDevice> activeDevices;

		private static readonly List<PlayerActionSet> playerActionSets;

		public static ReadOnlyCollection<InputDevice> Devices;

		public static ReadOnlyCollection<InputDevice> ActiveDevices;

		private static bool applicationIsFocused;

		private static float initialTime;

		private static float currentTime;

		private static float lastUpdateTime;

		private static ulong currentTick;

		private static VersionInfo? unityVersion;

		private static bool enabled;

		public static bool CommandWasPressed { get; private set; }

		public static bool InvertYAxis { get; set; }

		public static bool IsSetup { get; private set; }

		internal static string Platform { get; private set; }

		[Obsolete]
		public static bool MenuWasPressed => false;

		public static bool AnyKeyIsPressed => false;

		public static InputDevice ActiveDevice
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static bool Enabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static bool SuspendInBackground { get; set; }

		public static bool EnableNativeInput { get; internal set; }

		public static bool EnableXInput { get; internal set; }

		public static uint XInputUpdateRate { get; internal set; }

		public static uint XInputBufferSize { get; internal set; }

		public static bool NativeInputEnableXInput { get; internal set; }

		public static bool NativeInputEnableMFi { get; internal set; }

		public static bool NativeInputPreventSleep { get; internal set; }

		public static uint NativeInputUpdateRate { get; internal set; }

		public static bool EnableICade { get; internal set; }

		internal static VersionInfo UnityVersion => default(VersionInfo);

		public static ulong CurrentTick => 0uL;

		public static event Action OnSetup
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action<ulong, float> OnUpdate
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action OnReset
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action<InputDevice> OnDeviceAttached
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action<InputDevice> OnDeviceDetached
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action<InputDevice> OnActiveDeviceChanged
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		internal static event Action<ulong, float> OnUpdateDevices
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		internal static event Action<ulong, float> OnCommitDevices
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		internal static bool SetupInternal()
		{
			return false;
		}

		internal static void ResetInternal()
		{
		}

		public static void Update()
		{
		}

		internal static void UpdateInternal()
		{
		}

		public static void Reload()
		{
		}

		private static void AssertIsSetup()
		{
		}

		private static void SetZeroTickOnAllControls()
		{
		}

		public static void ClearInputState()
		{
		}

		internal static void OnApplicationFocus(bool focusState)
		{
		}

		internal static void OnApplicationPause(bool pauseState)
		{
		}

		internal static void OnApplicationQuit()
		{
		}

		internal static void OnLevelWasLoaded()
		{
		}

		public static void AddDeviceManager(InputDeviceManager deviceManager)
		{
		}

		public static void AddDeviceManager<T>() where T : InputDeviceManager, new()
		{
		}

		public static T GetDeviceManager<T>() where T : InputDeviceManager
		{
			return null;
		}

		public static bool HasDeviceManager<T>() where T : InputDeviceManager
		{
			return false;
		}

		private static void UpdateCurrentTime()
		{
		}

		private static void UpdateDeviceManagers(float deltaTime)
		{
		}

		private static void DestroyDeviceManagers()
		{
		}

		private static void DestroyDevices()
		{
		}

		private static void UpdateDevices(float deltaTime)
		{
		}

		private static void CommitDevices(float deltaTime)
		{
		}

		private static void UpdateActiveDevice()
		{
		}

		public static void AttachDevice(InputDevice inputDevice)
		{
		}

		public static void DetachDevice(InputDevice inputDevice)
		{
		}

		public static void HideDevicesWithProfile(Type type)
		{
		}

		internal static void AttachPlayerActionSet(PlayerActionSet playerActionSet)
		{
		}

		internal static void DetachPlayerActionSet(PlayerActionSet playerActionSet)
		{
		}

		internal static void UpdatePlayerActionSets(float deltaTime)
		{
		}
	}
}

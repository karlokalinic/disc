using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace InControl
{
	public class NativeInputDeviceManager : InputDeviceManager
	{
		public static Func<InputDeviceInfo, ReadOnlyCollection<NativeInputDevice>, NativeInputDevice> CustomFindDetachedDevice;

		private readonly List<NativeInputDevice> attachedDevices;

		private readonly List<NativeInputDevice> detachedDevices;

		private readonly List<InputDeviceProfile> systemDeviceProfiles;

		private readonly List<InputDeviceProfile> customDeviceProfiles;

		private uint[] deviceEvents;

		public override void Destroy()
		{
		}

		public override void Update(ulong updateTick, float deltaTime)
		{
		}

		private void DetectDevice(uint deviceHandle, InputDeviceInfo deviceInfo)
		{
		}

		private void AttachDevice(NativeInputDevice device)
		{
		}

		private void DetachDevice(NativeInputDevice device)
		{
		}

		private NativeInputDevice FindAttachedDevice(uint deviceHandle)
		{
			return null;
		}

		private NativeInputDevice FindDetachedDevice(InputDeviceInfo deviceInfo)
		{
			return null;
		}

		private static NativeInputDevice SystemFindDetachedDevice(InputDeviceInfo deviceInfo, ReadOnlyCollection<NativeInputDevice> detachedDevices)
		{
			return null;
		}

		private void AddSystemDeviceProfile(InputDeviceProfile deviceProfile)
		{
		}

		private void AddSystemDeviceProfiles()
		{
		}

		public static bool CheckPlatformSupport(ICollection<string> errors)
		{
			return false;
		}

		internal static bool Enable()
		{
			return false;
		}
	}
}

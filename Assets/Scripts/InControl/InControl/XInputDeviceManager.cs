using System.Collections.Generic;
using System.Threading;
using InControl.Internal;
using XInputDotNetPure;

namespace InControl
{
	public class XInputDeviceManager : InputDeviceManager
	{
		private readonly bool[] deviceConnected;

		private const int maxDevices = 4;

		private readonly RingBuffer<GamePadState>[] gamePadState;

		private Thread thread;

		private readonly int timeStep;

		private int bufferSize;

		private void StartWorker()
		{
		}

		private void StopWorker()
		{
		}

		private void Worker()
		{
		}

		internal GamePadState GetState(int deviceIndex)
		{
			return default(GamePadState);
		}

		public override void Update(ulong updateTick, float deltaTime)
		{
		}

		public override void Destroy()
		{
		}

		public static bool CheckPlatformSupport(ICollection<string> errors)
		{
			return false;
		}

		internal static void Enable()
		{
		}
	}
}

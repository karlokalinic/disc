using System;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class GameServerGlobalSpecificUserDataListener : ISpecificUserDataListener
	{
		private HandleRef swigCPtr;

		internal GameServerGlobalSpecificUserDataListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public GameServerGlobalSpecificUserDataListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(GameServerGlobalSpecificUserDataListener obj)
		{
			return default(HandleRef);
		}

		~GameServerGlobalSpecificUserDataListener()
		{
		}

		public override void Dispose()
		{
		}
	}
}

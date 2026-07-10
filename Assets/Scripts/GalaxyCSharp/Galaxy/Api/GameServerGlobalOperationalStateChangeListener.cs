using System;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class GameServerGlobalOperationalStateChangeListener : IOperationalStateChangeListener
	{
		private HandleRef swigCPtr;

		internal GameServerGlobalOperationalStateChangeListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public GameServerGlobalOperationalStateChangeListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(GameServerGlobalOperationalStateChangeListener obj)
		{
			return default(HandleRef);
		}

		~GameServerGlobalOperationalStateChangeListener()
		{
		}

		public override void Dispose()
		{
		}
	}
}

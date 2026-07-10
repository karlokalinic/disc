using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class GameServerGlobalUserInformationRetrieveListener : IUserInformationRetrieveListener
	{
		private static Dictionary<IntPtr, GameServerGlobalUserInformationRetrieveListener> listeners;

		private HandleRef swigCPtr;

		internal GameServerGlobalUserInformationRetrieveListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public GameServerGlobalUserInformationRetrieveListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(GameServerGlobalUserInformationRetrieveListener obj)
		{
			return default(HandleRef);
		}

		~GameServerGlobalUserInformationRetrieveListener()
		{
		}

		public override void Dispose()
		{
		}
	}
}

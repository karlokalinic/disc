using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class GlobalUserInformationRetrieveListener : IUserInformationRetrieveListener
	{
		private static Dictionary<IntPtr, GlobalUserInformationRetrieveListener> listeners;

		private HandleRef swigCPtr;

		internal GlobalUserInformationRetrieveListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public GlobalUserInformationRetrieveListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(GlobalUserInformationRetrieveListener obj)
		{
			return default(HandleRef);
		}

		~GlobalUserInformationRetrieveListener()
		{
		}

		public override void Dispose()
		{
		}
	}
}

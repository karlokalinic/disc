using System;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class GlobalEncryptedAppTicketListener : IEncryptedAppTicketListener
	{
		private HandleRef swigCPtr;

		internal GlobalEncryptedAppTicketListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public GlobalEncryptedAppTicketListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(GlobalEncryptedAppTicketListener obj)
		{
			return default(HandleRef);
		}

		~GlobalEncryptedAppTicketListener()
		{
		}

		public override void Dispose()
		{
		}
	}
}

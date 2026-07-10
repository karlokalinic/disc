using System;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class GameServerGlobalEncryptedAppTicketListener : IEncryptedAppTicketListener
	{
		private HandleRef swigCPtr;

		internal GameServerGlobalEncryptedAppTicketListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public GameServerGlobalEncryptedAppTicketListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(GameServerGlobalEncryptedAppTicketListener obj)
		{
			return default(HandleRef);
		}

		~GameServerGlobalEncryptedAppTicketListener()
		{
		}

		public override void Dispose()
		{
		}
	}
}

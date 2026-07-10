using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Sessions
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 48)]
	internal struct RegisterPlayersCallbackInfoInternal : ICallbackInfoInternal
	{
		private Result m_ResultCode;

		private IntPtr m_ClientData;

		private IntPtr m_RegisteredPlayers;

		private uint m_RegisteredPlayersCount;

		private IntPtr m_SanctionedPlayers;

		private uint m_SanctionedPlayersCount;

		public Result ResultCode => default(Result);

		public object ClientData => null;

		public IntPtr ClientDataAddress => (IntPtr)0;

		public ProductUserId[] RegisteredPlayers => null;

		public ProductUserId[] SanctionedPlayers => null;
	}
}

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.RTCAudio
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 8)]
	internal struct AudioDevicesChangedCallbackInfoInternal : ICallbackInfoInternal
	{
		private IntPtr m_ClientData;

		public object ClientData => null;

		public IntPtr ClientDataAddress => (IntPtr)0;
	}
}

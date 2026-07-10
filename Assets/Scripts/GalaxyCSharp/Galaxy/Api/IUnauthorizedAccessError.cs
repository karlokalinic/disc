using System;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public class IUnauthorizedAccessError : IError
	{
		private HandleRef swigCPtr;

		internal IUnauthorizedAccessError(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(IUnauthorizedAccessError obj)
		{
			return default(HandleRef);
		}

		~IUnauthorizedAccessError()
		{
		}

		public override void Dispose()
		{
		}
	}
}

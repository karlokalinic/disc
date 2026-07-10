using System;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public class IInvalidStateError : IError
	{
		private HandleRef swigCPtr;

		internal IInvalidStateError(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(IInvalidStateError obj)
		{
			return default(HandleRef);
		}

		~IInvalidStateError()
		{
		}

		public override void Dispose()
		{
		}
	}
}

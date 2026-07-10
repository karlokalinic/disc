using System;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public class IRuntimeError : IError
	{
		private HandleRef swigCPtr;

		internal IRuntimeError(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(IRuntimeError obj)
		{
			return default(HandleRef);
		}

		~IRuntimeError()
		{
		}

		public override void Dispose()
		{
		}
	}
}

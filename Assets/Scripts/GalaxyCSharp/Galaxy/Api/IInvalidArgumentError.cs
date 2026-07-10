using System;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public class IInvalidArgumentError : IError
	{
		private HandleRef swigCPtr;

		internal IInvalidArgumentError(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(IInvalidArgumentError obj)
		{
			return default(HandleRef);
		}

		~IInvalidArgumentError()
		{
		}

		public override void Dispose()
		{
		}
	}
}

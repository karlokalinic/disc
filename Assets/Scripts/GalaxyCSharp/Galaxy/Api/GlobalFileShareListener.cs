using System;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class GlobalFileShareListener : IFileShareListener
	{
		private HandleRef swigCPtr;

		internal GlobalFileShareListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public GlobalFileShareListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(GlobalFileShareListener obj)
		{
			return default(HandleRef);
		}

		~GlobalFileShareListener()
		{
		}

		public override void Dispose()
		{
		}
	}
}

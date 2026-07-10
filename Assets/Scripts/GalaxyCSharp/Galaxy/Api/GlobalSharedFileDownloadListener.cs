using System;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class GlobalSharedFileDownloadListener : ISharedFileDownloadListener
	{
		private HandleRef swigCPtr;

		internal GlobalSharedFileDownloadListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public GlobalSharedFileDownloadListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(GlobalSharedFileDownloadListener obj)
		{
			return default(HandleRef);
		}

		~GlobalSharedFileDownloadListener()
		{
		}

		public override void Dispose()
		{
		}
	}
}

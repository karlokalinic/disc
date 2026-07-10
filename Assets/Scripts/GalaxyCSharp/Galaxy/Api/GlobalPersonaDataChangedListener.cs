using System;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class GlobalPersonaDataChangedListener : IPersonaDataChangedListener
	{
		private HandleRef swigCPtr;

		internal GlobalPersonaDataChangedListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public GlobalPersonaDataChangedListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(GlobalPersonaDataChangedListener obj)
		{
			return default(HandleRef);
		}

		~GlobalPersonaDataChangedListener()
		{
		}

		public override void Dispose()
		{
		}
	}
}

using System;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public class ShutdownParams : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public bool preserveStaticObjects
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		internal ShutdownParams(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		public ShutdownParams(bool _preserveStaticObjects)
		{
		}

		internal static HandleRef getCPtr(ShutdownParams obj)
		{
			return default(HandleRef);
		}

		~ShutdownParams()
		{
		}

		public virtual void Dispose()
		{
		}
	}
}

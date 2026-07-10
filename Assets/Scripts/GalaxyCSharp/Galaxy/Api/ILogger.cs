using System;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public class ILogger : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		internal ILogger(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		internal static HandleRef getCPtr(ILogger obj)
		{
			return default(HandleRef);
		}

		~ILogger()
		{
		}

		public virtual void Dispose()
		{
		}

		public virtual void Trace(string format)
		{
		}

		public virtual void Debug(string format)
		{
		}

		public virtual void Info(string format)
		{
		}

		public virtual void Warning(string format)
		{
		}

		public virtual void Error(string format)
		{
		}

		public virtual void Fatal(string format)
		{
		}
	}
}

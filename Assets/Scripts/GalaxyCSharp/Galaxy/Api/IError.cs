using System;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public class IError : IDisposable
	{
		public enum Type
		{
			UNAUTHORIZED_ACCESS = 0,
			INVALID_ARGUMENT = 1,
			INVALID_STATE = 2,
			RUNTIME_ERROR = 3
		}

		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		internal IError(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		internal static HandleRef getCPtr(IError obj)
		{
			return default(HandleRef);
		}

		~IError()
		{
		}

		public virtual void Dispose()
		{
		}

		public override string ToString()
		{
			return null;
		}

		public virtual string GetName()
		{
			return null;
		}

		public virtual string GetMsg()
		{
			return null;
		}

		public virtual Type GetErrorType()
		{
			return default(Type);
		}
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public class IPlayFabLoginWithOpenIDConnectListener : IDisposable
	{
		public enum FailureReason
		{
			FAILURE_REASON_UNDEFINED = 0,
			FAILURE_REASON_CONNECTION_FAILURE = 1
		}

		private static Dictionary<IntPtr, IPlayFabLoginWithOpenIDConnectListener> listeners;

		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		internal IPlayFabLoginWithOpenIDConnectListener(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		internal static HandleRef getCPtr(IPlayFabLoginWithOpenIDConnectListener obj)
		{
			return default(HandleRef);
		}

		~IPlayFabLoginWithOpenIDConnectListener()
		{
		}

		public virtual void Dispose()
		{
		}

		public virtual void OnPlayFabLoginWithOpenIDConnectSuccess()
		{
		}

		public virtual void OnPlayFabLoginWithOpenIDConnectFailure(FailureReason failureReason)
		{
		}
	}
}

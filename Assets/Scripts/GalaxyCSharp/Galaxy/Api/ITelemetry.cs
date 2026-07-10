using System;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public class ITelemetry : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		internal ITelemetry(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		internal static HandleRef getCPtr(ITelemetry obj)
		{
			return default(HandleRef);
		}

		~ITelemetry()
		{
		}

		public virtual void Dispose()
		{
		}

		public virtual void AddStringParam(string name, string value)
		{
		}

		public virtual void AddIntParam(string name, int value)
		{
		}

		public virtual void AddFloatParam(string name, double value)
		{
		}

		public virtual void AddBoolParam(string name, bool value)
		{
		}

		public virtual void AddObjectParam(string name)
		{
		}

		public virtual void AddArrayParam(string name)
		{
		}

		public virtual void CloseParam()
		{
		}

		public virtual void ClearParams()
		{
		}

		public virtual void SetSamplingClass(string name)
		{
		}

		public virtual uint SendTelemetryEvent(string eventType, ITelemetryEventSendListener listener)
		{
			return 0u;
		}

		public virtual uint SendTelemetryEvent(string eventType)
		{
			return 0u;
		}

		public virtual uint SendAnonymousTelemetryEvent(string eventType, ITelemetryEventSendListener listener)
		{
			return 0u;
		}

		public virtual uint SendAnonymousTelemetryEvent(string eventType)
		{
			return 0u;
		}

		public virtual string GetVisitID()
		{
			return null;
		}

		public virtual void GetVisitIDCopy(out string buffer, uint bufferLength)
		{
			buffer = null;
		}

		public virtual void ResetVisitID()
		{
		}
	}
}

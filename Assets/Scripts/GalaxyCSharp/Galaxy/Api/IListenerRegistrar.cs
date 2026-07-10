using System;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public class IListenerRegistrar : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		internal IListenerRegistrar(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		internal static HandleRef getCPtr(IListenerRegistrar obj)
		{
			return default(HandleRef);
		}

		~IListenerRegistrar()
		{
		}

		public virtual void Dispose()
		{
		}

		public virtual void Register(ListenerType listenerType, IGalaxyListener listener)
		{
		}

		public virtual void Unregister(ListenerType listenerType, IGalaxyListener listener)
		{
		}
	}
}

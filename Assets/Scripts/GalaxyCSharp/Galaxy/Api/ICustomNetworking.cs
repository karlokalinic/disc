using System;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public class ICustomNetworking : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		internal ICustomNetworking(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		internal static HandleRef getCPtr(ICustomNetworking obj)
		{
			return default(HandleRef);
		}

		~ICustomNetworking()
		{
		}

		public virtual void Dispose()
		{
		}

		public virtual void OpenConnection(string connectionString, IConnectionOpenListener listener)
		{
		}

		public virtual void OpenConnection(string connectionString)
		{
		}

		public virtual void CloseConnection(ulong connectionID, IConnectionCloseListener listener)
		{
		}

		public virtual void CloseConnection(ulong connectionID)
		{
		}

		public virtual void SendData(ulong connectionID, byte[] data, uint dataSize)
		{
		}

		public virtual uint GetAvailableDataSize(ulong connectionID)
		{
			return 0u;
		}

		public virtual void PeekData(ulong connectionID, byte[] dest, uint dataSize)
		{
		}

		public virtual void ReadData(ulong connectionID, byte[] dest, uint dataSize)
		{
		}

		public virtual void PopData(ulong connectionID, uint dataSize)
		{
		}
	}
}

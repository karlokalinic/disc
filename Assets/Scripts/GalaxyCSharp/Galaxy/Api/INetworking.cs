using System;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public class INetworking : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		internal INetworking(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		internal static HandleRef getCPtr(INetworking obj)
		{
			return default(HandleRef);
		}

		~INetworking()
		{
		}

		public virtual void Dispose()
		{
		}

		public virtual bool SendP2PPacket(GalaxyID galaxyID, byte[] data, uint dataSize, P2PSendType sendType, byte channel)
		{
			return false;
		}

		public virtual bool SendP2PPacket(GalaxyID galaxyID, byte[] data, uint dataSize, P2PSendType sendType)
		{
			return false;
		}

		public virtual bool PeekP2PPacket(byte[] dest, uint destSize, ref uint outMsgSize, ref GalaxyID outGalaxyID, byte channel)
		{
			return false;
		}

		public virtual bool PeekP2PPacket(byte[] dest, uint destSize, ref uint outMsgSize, ref GalaxyID outGalaxyID)
		{
			return false;
		}

		public virtual bool IsP2PPacketAvailable(ref uint outMsgSize, byte channel)
		{
			return false;
		}

		public virtual bool IsP2PPacketAvailable(ref uint outMsgSize)
		{
			return false;
		}

		public virtual bool ReadP2PPacket(byte[] dest, uint destSize, ref uint outMsgSize, ref GalaxyID outGalaxyID, byte channel)
		{
			return false;
		}

		public virtual bool ReadP2PPacket(byte[] dest, uint destSize, ref uint outMsgSize, ref GalaxyID outGalaxyID)
		{
			return false;
		}

		public virtual void PopP2PPacket(byte channel)
		{
		}

		public virtual void PopP2PPacket()
		{
		}

		public virtual int GetPingWith(GalaxyID galaxyID)
		{
			return 0;
		}

		public virtual void RequestNatTypeDetection()
		{
		}

		public virtual NatType GetNatType()
		{
			return default(NatType);
		}

		public virtual ConnectionType GetConnectionType(GalaxyID userID)
		{
			return default(ConnectionType);
		}
	}
}

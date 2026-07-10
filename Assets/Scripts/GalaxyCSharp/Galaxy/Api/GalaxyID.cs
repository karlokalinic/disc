using System;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public class GalaxyID : IDisposable
	{
		public enum IDType
		{
			ID_TYPE_UNASSIGNED = 0,
			ID_TYPE_LOBBY = 1,
			ID_TYPE_USER = 2
		}

		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public static readonly ulong UNASSIGNED_VALUE;

		internal GalaxyID(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		public GalaxyID()
		{
		}

		public GalaxyID(ulong _value)
		{
		}

		public GalaxyID(GalaxyID galaxyID)
		{
		}

		internal static HandleRef getCPtr(GalaxyID obj)
		{
			return default(HandleRef);
		}

		~GalaxyID()
		{
		}

		public virtual void Dispose()
		{
		}

		public static bool operator ==(GalaxyID other1, GalaxyID other2)
		{
			return false;
		}

		public static bool operator !=(GalaxyID other1, GalaxyID other2)
		{
			return false;
		}

		public static bool operator <(GalaxyID other1, GalaxyID other2)
		{
			return false;
		}

		public static bool operator >(GalaxyID other1, GalaxyID other2)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override string ToString()
		{
			return null;
		}

		public static GalaxyID FromRealID(IDType type, ulong value)
		{
			return null;
		}

		private GalaxyID operator_assign(GalaxyID other)
		{
			return null;
		}

		private bool operator_less(GalaxyID other)
		{
			return false;
		}

		private bool operator_equals(GalaxyID other)
		{
			return false;
		}

		private bool operator_not_equals(GalaxyID other)
		{
			return false;
		}

		public bool IsValid()
		{
			return false;
		}

		public ulong ToUint64()
		{
			return 0uL;
		}

		public ulong GetRealID()
		{
			return 0uL;
		}

		public IDType GetIDType()
		{
			return default(IDType);
		}
	}
}

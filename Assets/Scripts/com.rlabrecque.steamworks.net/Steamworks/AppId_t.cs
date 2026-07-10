using System;

namespace Steamworks
{
	[Serializable]
	public struct AppId_t : IEquatable<AppId_t>, IComparable<AppId_t>
	{
		public static readonly AppId_t Invalid;

		public uint m_AppId;

		public AppId_t(uint value)
		{
			m_AppId = 0u;
		}

		public override string ToString()
		{
			return null;
		}

		public override bool Equals(object other)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public static bool operator ==(AppId_t x, AppId_t y)
		{
			return false;
		}

		public static bool operator !=(AppId_t x, AppId_t y)
		{
			return false;
		}

		public bool Equals(AppId_t other)
		{
			return false;
		}

		public int CompareTo(AppId_t other)
		{
			return 0;
		}
	}
}

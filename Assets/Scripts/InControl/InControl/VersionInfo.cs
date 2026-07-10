using System;
using UnityEngine;

namespace InControl
{
	[Serializable]
	public struct VersionInfo : IComparable<VersionInfo>
	{
		[SerializeField]
		private int major;

		[SerializeField]
		private int minor;

		[SerializeField]
		private int patch;

		[SerializeField]
		private int build;

		public static VersionInfo Min => default(VersionInfo);

		public static VersionInfo Max => default(VersionInfo);

		public VersionInfo Next => default(VersionInfo);

		public int Build => 0;

		public VersionInfo(int major, int minor, int patch, int build)
		{
			this.major = 0;
			this.minor = 0;
			this.patch = 0;
			this.build = 0;
		}

		public static VersionInfo InControlVersion()
		{
			return default(VersionInfo);
		}

		public static VersionInfo UnityVersion()
		{
			return default(VersionInfo);
		}

		public int CompareTo(VersionInfo other)
		{
			return 0;
		}

		public static bool operator ==(VersionInfo a, VersionInfo b)
		{
			return false;
		}

		public static bool operator !=(VersionInfo a, VersionInfo b)
		{
			return false;
		}

		public static bool operator <=(VersionInfo a, VersionInfo b)
		{
			return false;
		}

		public static bool operator >=(VersionInfo a, VersionInfo b)
		{
			return false;
		}

		public static bool operator <(VersionInfo a, VersionInfo b)
		{
			return false;
		}

		public static bool operator >(VersionInfo a, VersionInfo b)
		{
			return false;
		}

		public override bool Equals(object other)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override string ToString()
		{
			return null;
		}

		public string ToShortString()
		{
			return null;
		}
	}
}

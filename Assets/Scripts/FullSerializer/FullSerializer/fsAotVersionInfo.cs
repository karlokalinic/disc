using FullSerializer.Internal;

namespace FullSerializer
{
	public struct fsAotVersionInfo
	{
		public struct Member
		{
			public string MemberName;

			public string JsonName;

			public string StorageType;

			public string OverrideConverterType;

			public Member(fsMetaProperty property)
			{
				MemberName = null;
				JsonName = null;
				StorageType = null;
				OverrideConverterType = null;
			}

			public override bool Equals(object obj)
			{
				return false;
			}

			public override int GetHashCode()
			{
				return 0;
			}

			public static bool operator ==(Member a, Member b)
			{
				return false;
			}

			public static bool operator !=(Member a, Member b)
			{
				return false;
			}
		}

		public bool IsConstructorPublic;

		public Member[] Members;
	}
}

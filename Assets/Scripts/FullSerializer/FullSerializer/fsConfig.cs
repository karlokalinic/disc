using System;
using System.Reflection;

namespace FullSerializer
{
	public class fsConfig
	{
		public Type[] SerializeAttributes;

		public Type[] IgnoreSerializeAttributes;

		public Type[] IgnoreSerializeTypeAttributes;

		public fsMemberSerialization DefaultMemberSerialization;

		public Func<string, MemberInfo, string> GetJsonNameFromMemberName;

		public bool EnablePropertySerialization;

		public bool SerializeNonAutoProperties;

		public bool SerializeNonPublicSetProperties;

		public string CustomDateTimeFormatString;

		public bool Serialize64BitIntegerAsString;

		public bool SerializeEnumsAsInteger;
	}
}

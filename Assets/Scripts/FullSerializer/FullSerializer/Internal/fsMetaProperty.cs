using System;
using System.Reflection;

namespace FullSerializer.Internal
{
	public class fsMetaProperty
	{
		private MemberInfo _memberInfo;

		public Type StorageType { get; private set; }

		public Type OverrideConverterType { get; private set; }

		public bool CanRead { get; private set; }

		public bool CanWrite { get; private set; }

		public string JsonName { get; private set; }

		public string MemberName { get; private set; }

		public bool IsPublic { get; private set; }

		public bool IsReadOnly { get; private set; }

		internal fsMetaProperty(fsConfig config, FieldInfo field)
		{
		}

		internal fsMetaProperty(fsConfig config, PropertyInfo property)
		{
		}

		private void CommonInitialize(fsConfig config)
		{
		}

		public void Write(object context, object value)
		{
		}

		public object Read(object context)
		{
			return null;
		}
	}
}

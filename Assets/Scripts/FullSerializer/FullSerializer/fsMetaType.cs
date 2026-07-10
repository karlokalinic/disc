using System;
using System.Collections.Generic;
using System.Reflection;
using FullSerializer.Internal;

namespace FullSerializer
{
	public class fsMetaType
	{
		public class AotFailureException : Exception
		{
			public AotFailureException(string reason)
			{
			}
		}

		private static Dictionary<fsConfig, Dictionary<Type, fsMetaType>> _configMetaTypes;

		public Type ReflectedType;

		private bool? _hasDefaultConstructorCache;

		private bool? _isDefaultConstructorPublicCache;

		public fsMetaProperty[] Properties { get; private set; }

		public bool HasDefaultConstructor => false;

		public bool IsDefaultConstructorPublic => false;

		public static fsMetaType Get(fsConfig config, Type type)
		{
			return null;
		}

		public static void ClearCache()
		{
		}

		private fsMetaType(fsConfig config, Type reflectedType)
		{
		}

		private static void CollectProperties(fsConfig config, List<fsMetaProperty> properties, Type reflectedType)
		{
		}

		private static bool IsAutoProperty(PropertyInfo property, MemberInfo[] members)
		{
			return false;
		}

		private static bool CanSerializeProperty(fsConfig config, PropertyInfo property, MemberInfo[] members, bool annotationFreeValue)
		{
			return false;
		}

		private static bool CanSerializeField(fsConfig config, FieldInfo field, bool annotationFreeValue)
		{
			return false;
		}

		public void EmitAotData(bool throwException)
		{
		}

		public object CreateInstance()
		{
			return null;
		}
	}
}

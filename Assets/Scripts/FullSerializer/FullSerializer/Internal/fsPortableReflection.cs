using System;
using System.Collections.Generic;
using System.Reflection;

namespace FullSerializer.Internal
{
	public static class fsPortableReflection
	{
		private struct AttributeQuery
		{
			public MemberInfo MemberInfo;

			public Type AttributeType;
		}

		private class AttributeQueryComparator : IEqualityComparer<AttributeQuery>
		{
			public bool Equals(AttributeQuery x, AttributeQuery y)
			{
				return false;
			}

			public int GetHashCode(AttributeQuery obj)
			{
				return 0;
			}
		}

		public static Type[] EmptyTypes;

		private static IDictionary<AttributeQuery, Attribute> _cachedAttributeQueries;

		private static BindingFlags DeclaredFlags;

		public static bool HasAttribute<TAttribute>(MemberInfo element)
		{
			return false;
		}

		public static bool HasAttribute<TAttribute>(MemberInfo element, bool shouldCache)
		{
			return false;
		}

		public static bool HasAttribute(MemberInfo element, Type attributeType)
		{
			return false;
		}

		public static bool HasAttribute(MemberInfo element, Type attributeType, bool shouldCache)
		{
			return false;
		}

		public static Attribute GetAttribute(MemberInfo element, Type attributeType, bool shouldCache)
		{
			return null;
		}

		public static TAttribute GetAttribute<TAttribute>(MemberInfo element, bool shouldCache) where TAttribute : Attribute
		{
			return null;
		}

		public static TAttribute GetAttribute<TAttribute>(MemberInfo element) where TAttribute : Attribute
		{
			return null;
		}

		public static PropertyInfo GetDeclaredProperty(this Type type, string propertyName)
		{
			return null;
		}

		public static MethodInfo GetDeclaredMethod(this Type type, string methodName)
		{
			return null;
		}

		public static ConstructorInfo GetDeclaredConstructor(this Type type, Type[] parameters)
		{
			return null;
		}

		public static ConstructorInfo[] GetDeclaredConstructors(this Type type)
		{
			return null;
		}

		public static MemberInfo[] GetFlattenedMember(this Type type, string memberName)
		{
			return null;
		}

		public static MethodInfo GetFlattenedMethod(this Type type, string methodName)
		{
			return null;
		}

		public static IEnumerable<MethodInfo> GetFlattenedMethods(this Type type, string methodName)
		{
			return null;
		}

		public static PropertyInfo GetFlattenedProperty(this Type type, string propertyName)
		{
			return null;
		}

		public static MemberInfo GetDeclaredMember(this Type type, string memberName)
		{
			return null;
		}

		public static MethodInfo[] GetDeclaredMethods(this Type type)
		{
			return null;
		}

		public static PropertyInfo[] GetDeclaredProperties(this Type type)
		{
			return null;
		}

		public static FieldInfo[] GetDeclaredFields(this Type type)
		{
			return null;
		}

		public static MemberInfo[] GetDeclaredMembers(this Type type)
		{
			return null;
		}

		public static MemberInfo AsMemberInfo(Type type)
		{
			return null;
		}

		public static bool IsType(MemberInfo member)
		{
			return false;
		}

		public static Type AsType(MemberInfo member)
		{
			return null;
		}

		public static Type Resolve(this Type type)
		{
			return null;
		}
	}
}

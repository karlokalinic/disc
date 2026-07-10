using System.Collections.Generic;
using UnityEngine;

namespace Voidforge
{
	public static class ComponentExtensions
	{
		public static bool Release(this GameObject gameObject, bool tryToRecycle = true)
		{
			return false;
		}

		public static bool Release(this Component component)
		{
			return false;
		}

		public static T GetComponent<T>(this Component component, GetComponentAttribute config) where T : Component
		{
			return null;
		}

		public static T GetComponent<T>(this Component component, bool includeInactive) where T : Component
		{
			return null;
		}

		public static T GetComponentInParent<T>(this Component component, bool includeInactive) where T : Component
		{
			return null;
		}

		public static List<T> GetComponents<T>(this Component component, bool includeInactive) where T : Component
		{
			return null;
		}

		public static List<T> GetComponents<T>(this Component component, GetComponentAttribute config) where T : Component
		{
			return null;
		}

		public static string GetId(this Component component)
		{
			return null;
		}

		public static string[] GetIds(this ICollection<Component> components)
		{
			return null;
		}

		public static void SetId(this Component component, string id)
		{
		}

		public static V GetMemberByName<T, V>(this Component component, string name) where T : Component
		{
			return default(V);
		}

		public static bool GetMemberByName<T, V>(this Component component, string name, out V value) where T : Component
		{
			value = default(V);
			return false;
		}

		public static V GetMemberByName<T1, T2, V>(this Component component, string name) where T1 : Component where T2 : Component
		{
			return default(V);
		}

		public static bool GetMemberByName<T1, T2, V>(this Component component, string name, out V value) where T1 : Component where T2 : Component
		{
			value = default(V);
			return false;
		}

		public static V GetMemberByName<T1, T2, T3, V>(this Component component, string name) where T1 : Component where T2 : Component where T3 : Component
		{
			return default(V);
		}

		public static bool GetMemberByName<T1, T2, T3, V>(this Component component, string name, out V value) where T1 : Component where T2 : Component where T3 : Component
		{
			value = default(V);
			return false;
		}

		public static V GetMemberByName<T1, T2, T3, T4, V>(this Component component, string name) where T1 : Component where T2 : Component where T3 : Component where T4 : Component
		{
			return default(V);
		}

		public static bool GetMemberByName<T1, T2, T3, T4, V>(this Component component, string name, out V value) where T1 : Component where T2 : Component where T3 : Component where T4 : Component
		{
			value = default(V);
			return false;
		}

		public static Transform GetSelectable(this Component component)
		{
			return null;
		}

		public static T Tag<T>(this Component component) where T : VoidTag
		{
			return null;
		}
	}
}

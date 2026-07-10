using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

namespace Voidforge
{
	public class VoidElement : MonoBehaviour
	{
		private static Dictionary<Type, Dictionary<MemberInfo, Attribute[]>> memberBuffer;

		protected void ClearComponentRefs(bool parent = true, bool children = false, bool self = false)
		{
		}

		protected void InitComponentRefs()
		{
		}

		protected void InitManagerAgents()
		{
		}

		protected Type ValueType(MemberInfo memberInfo)
		{
			return null;
		}

		protected void DrawGizmoCube(Vector3 position, bool wireFrame = false)
		{
		}

		protected void DrawGizmoSphere(Vector3 position, bool wireFrame = false)
		{
		}

		protected VoidElement()
		{
		}

		protected virtual void Awake()
		{
		}

		public void Warmup()
		{
		}
	}
}

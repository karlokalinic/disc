using UnityEngine;
using UnityEngine.AI;

namespace Voidforge
{
	public class NavMeshPathTag : VoidTag
	{
		protected int _areaMask;

		protected Vector3? _origin;

		protected Vector3? _target;

		protected NavMeshPath _path;

		protected Vector3[] _pathCorners;

		protected int _pathCornerCount;

		public int areaMask
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool isPathComplete => false;

		public NavMeshPath path => null;

		public Vector3? origin
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Vector3? target
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public void ForceUpdateVariables(Vector3 newOrigin, Vector3 newTarget, int newAreaMask)
		{
		}

		protected void OnDrawGizmos()
		{
		}
	}
}

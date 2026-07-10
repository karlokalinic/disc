using UnityEngine;

namespace Voidforge
{
	public struct TangentSpace
	{
		public readonly Vector3 tangent;

		public readonly Vector3 binormal;

		public readonly Vector3 normal;

		public TangentSpace(Vector3 n, Vector3 t, float tSign)
		{
			tangent = default(Vector3);
			binormal = default(Vector3);
			normal = default(Vector3);
		}

		public TangentSpace(Vector3 n, Vector4 t)
		{
			tangent = default(Vector3);
			binormal = default(Vector3);
			normal = default(Vector3);
		}

		public TangentSpace(Vector3 baryCoords, TangentSpace s0, TangentSpace s1, TangentSpace s2)
		{
			tangent = default(Vector3);
			binormal = default(Vector3);
			normal = default(Vector3);
		}

		public Vector3 InverseTransformDirection(Vector3 v)
		{
			return default(Vector3);
		}
	}
}

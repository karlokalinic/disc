using UnityEngine;

namespace Voidforge
{
	public static class MeshExtensions
	{
		public static Mesh Clone(this Mesh mesh)
		{
			return null;
		}

		public static void CalculateTangents(this Mesh mesh)
		{
		}

		public static Bounds TransformBounds(this Mesh mesh, Matrix4x4 transformMatrix, bool perVertex)
		{
			return default(Bounds);
		}
	}
}

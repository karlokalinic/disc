using System;
using UnityEngine;

namespace Sunshine.Unseen
{
	[Serializable]
	public struct Unseen
	{
		public float focus;

		public float saturation;

		public float brightness;

		public float aberration;

		public Unseen(float f, float s, float v, float a)
		{
			focus = 0f;
			saturation = 0f;
			brightness = 0f;
			aberration = 0f;
		}

		public Unseen(Vector4 value)
		{
			focus = 0f;
			saturation = 0f;
			brightness = 0f;
			aberration = 0f;
		}

		public static implicit operator Vector4(Unseen value)
		{
			return default(Vector4);
		}

		public static implicit operator Unseen(Vector4 value)
		{
			return default(Unseen);
		}
	}
}

using System;
using FortressOccident;
using UnityEngine;

namespace Sunshine
{
	public class BlendShapeIds : FOComponent
	{
		[Serializable]
		public class Entry
		{
			public string id;

			public string name;
		}

		[HideInInspector]
		[SerializeField]
		protected Entry[] items;

		public string[] blendShapeNames => null;

		public string Item => null;

		protected Mesh mesh => null;

		public int BlendShapeIndex(string name)
		{
			return 0;
		}
	}
}

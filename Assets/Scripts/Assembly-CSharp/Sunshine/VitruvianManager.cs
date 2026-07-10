using System.Collections.Generic;
using UnityEngine;

namespace Sunshine
{
	[CreateAssetMenu]
	public class VitruvianManager : ScriptableObject
	{
		[SerializeField]
		protected int textureSize;

		[SerializeField]
		protected List<string> layers;

		public static VitruvianManager current { get; set; }

		public int this[int index] => 0;

		public int this[long index] => 0;

		public string this[string key]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string[] allLayers => null;

		public int Count => 0;

		public int Size => 0;

		public string FindLayer(string objectId)
		{
			return null;
		}

		protected int CommonPrefixLength(string a, string b)
		{
			return 0;
		}

		protected void OnEnable()
		{
		}

		protected void OnDisable()
		{
		}
	}
}

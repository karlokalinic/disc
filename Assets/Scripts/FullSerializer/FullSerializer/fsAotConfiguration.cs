using System;
using System.Collections.Generic;
using UnityEngine;

namespace FullSerializer
{
	[CreateAssetMenu]
	public class fsAotConfiguration : ScriptableObject
	{
		public enum AotState
		{
			Default = 0,
			Enabled = 1,
			Disabled = 2
		}

		[Serializable]
		public struct Entry
		{
			public AotState State;

			public string FullTypeName;

			public Entry(Type type)
			{
				State = default(AotState);
				FullTypeName = null;
			}

			public Entry(Type type, AotState state)
			{
				State = default(AotState);
				FullTypeName = null;
			}
		}

		public List<Entry> aotTypes;

		public string outputDirectory;

		public bool TryFindEntry(Type type, out Entry result)
		{
			result = default(Entry);
			return false;
		}

		public void UpdateOrAddEntry(Entry entry)
		{
		}
	}
}

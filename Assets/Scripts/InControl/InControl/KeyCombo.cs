using System;
using System.Collections.Generic;
using System.IO;

namespace InControl
{
	public struct KeyCombo
	{
		private int includeSize;

		private ulong includeData;

		private int excludeSize;

		private ulong excludeData;

		private static Dictionary<ulong, string> cachedStrings;

		[Obsolete]
		public int Count => 0;

		public int IncludeCount => 0;

		public int ExcludeCount => 0;

		public bool IsPressed => false;

		public KeyCombo(params Key[] keys)
		{
			includeSize = 0;
			includeData = 0uL;
			excludeSize = 0;
			excludeData = 0uL;
		}

		private void AddIncludeInt(int key)
		{
		}

		private int GetIncludeInt(int index)
		{
			return 0;
		}

		[Obsolete]
		public void Add(Key key)
		{
		}

		[Obsolete]
		public Key Get(int index)
		{
			return default(Key);
		}

		public void AddInclude(Key key)
		{
		}

		public Key GetInclude(int index)
		{
			return default(Key);
		}

		private void AddExcludeInt(int key)
		{
		}

		private int GetExcludeInt(int index)
		{
			return 0;
		}

		public void AddExclude(Key key)
		{
		}

		public Key GetExclude(int index)
		{
			return default(Key);
		}

		public static KeyCombo With(params Key[] keys)
		{
			return default(KeyCombo);
		}

		public KeyCombo AndNot(params Key[] keys)
		{
			return default(KeyCombo);
		}

		public void Clear()
		{
		}

		public static KeyCombo Detect(bool modifiersAsKeys)
		{
			return default(KeyCombo);
		}

		public override string ToString()
		{
			return null;
		}

		public static bool operator ==(KeyCombo a, KeyCombo b)
		{
			return false;
		}

		public static bool operator !=(KeyCombo a, KeyCombo b)
		{
			return false;
		}

		public override bool Equals(object other)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		internal void Load(BinaryReader reader, ushort dataFormatVersion)
		{
		}

		internal void Save(BinaryWriter writer)
		{
		}
	}
}

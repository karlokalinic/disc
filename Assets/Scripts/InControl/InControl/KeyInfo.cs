using UnityEngine;

namespace InControl
{
	public struct KeyInfo
	{
		private readonly Key key;

		private readonly string name;

		private readonly string macName;

		private readonly KeyCode[] keyCodes;

		public static readonly KeyInfo[] KeyList;

		public bool IsPressed => false;

		public string Name => null;

		public Key Key => default(Key);

		private KeyInfo(Key key, string name, params KeyCode[] keyCodes)
		{
			this.key = default(Key);
			this.name = null;
			macName = null;
			this.keyCodes = null;
		}

		private KeyInfo(Key key, string name, string macName, params KeyCode[] keyCodes)
		{
			this.key = default(Key);
			this.name = null;
			this.macName = null;
			this.keyCodes = null;
		}
	}
}

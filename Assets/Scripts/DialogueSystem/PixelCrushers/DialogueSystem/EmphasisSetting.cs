using System;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	[Serializable]
	public class EmphasisSetting
	{
		public Color color;

		public bool bold;

		public bool italic;

		public bool underline;

		public bool IsEmpty => false;

		public EmphasisSetting(Color color, bool bold, bool italic, bool underline)
		{
		}

		public EmphasisSetting(string colorCode, string styleCode)
		{
		}
	}
}

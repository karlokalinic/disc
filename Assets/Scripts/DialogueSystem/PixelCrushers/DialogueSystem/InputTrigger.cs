using System;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	[Serializable]
	public class InputTrigger
	{
		public KeyCode key;

		public string buttonName;

		public bool isDown => false;

		public bool IsDown => false;

		public InputTrigger()
		{
		}

		public InputTrigger(KeyCode key)
		{
		}

		public InputTrigger(string buttonName)
		{
		}

		public InputTrigger(KeyCode key, string buttonName)
		{
		}
	}
}

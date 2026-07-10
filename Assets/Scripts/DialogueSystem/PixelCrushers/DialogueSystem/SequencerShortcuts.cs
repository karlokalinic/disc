using System;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	public class SequencerShortcuts : MonoBehaviour
	{
		[Serializable]
		public class Shortcut
		{
			public string shortcut;

			[TextArea]
			public string value;
		}

		public Shortcut[] shortcuts;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}
	}
}

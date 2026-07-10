using UnityEngine;

namespace Voidforge
{
	public class InputKeyAttribute : InputTriggerAttribute
	{
		public virtual KeyCode keyCode { get; protected set; }

		public KeyCode toKeyCode { get; protected set; }

		public bool isRange => false;

		public bool CanHandle(InputManager.KeyCodeEventData data)
		{
			return false;
		}

		public InputKeyAttribute(KeyCode key)
		{
		}

		public InputKeyAttribute(KeyCode fromKey, KeyCode toKey)
		{
		}
	}
}

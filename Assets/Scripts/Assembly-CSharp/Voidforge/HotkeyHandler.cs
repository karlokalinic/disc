using UnityEngine;

namespace Voidforge
{
	public class HotkeyHandler : VoidElement, InputManager.IKeyHandler
	{
		[SerializeField]
		protected KeyCode hotkey;

		public KeyCode[] InputKeys => null;

		string InputManager.IKeyHandler.name => null;

		public void OnInputKey()
		{
		}
	}
}

using UnityEngine;

namespace Voidforge
{
	public class HotkeyPriorityHandler : HotkeyHandler, InputManager.IPriority
	{
		[SerializeField]
		protected int priority;

		public int inputPriority => 0;
	}
}

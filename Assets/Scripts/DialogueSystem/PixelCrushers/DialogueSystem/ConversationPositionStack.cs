using System.Collections.Generic;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	public class ConversationPositionStack : MonoBehaviour
	{
		public bool clearOnConversationStart;

		public bool unregisterOnDisable;

		private static Stack<DialogueEntry> m_stack;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnConversationStart(Transform actor)
		{
		}

		public static void PushConversationPosition()
		{
		}

		public static void PopConversationPosition()
		{
		}

		public static void ClearConversationPositionStack()
		{
		}
	}
}

using System.Collections.Generic;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	public class QuestStateDispatcher : MonoBehaviour
	{
		private List<QuestStateListener> m_listeners;

		public void AddListener(QuestStateListener listener)
		{
		}

		public void RemoveListener(QuestStateListener listener)
		{
		}

		public void OnQuestStateChange(string questName)
		{
		}
	}
}

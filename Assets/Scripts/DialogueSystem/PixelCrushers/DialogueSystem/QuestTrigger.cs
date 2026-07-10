using System;
using System.Collections;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	public class QuestTrigger : DialogueEventStarter
	{
		[Serializable]
		public class SendMessageAction
		{
			public GameObject gameObject;

			public string message;

			public string parameter;
		}

		[DialogueTriggerEvent]
		public DialogueTriggerEvent trigger;

		public Condition condition;

		public string questName;

		public bool setQuestState;

		[QuestState]
		public QuestState questState;

		public bool setQuestEntryState;

		public int questEntryNumber;

		[QuestState]
		public QuestState questEntryState;

		public string luaCode;

		public string alertMessage;

		public LocalizedTextTable localizedTextTable;

		public SendMessageAction[] sendMessages;

		[HideInInspector]
		public bool useQuestNamePicker;

		[HideInInspector]
		public DialogueDatabase selectedDatabase;

		private bool tryingToStart;

		private bool listenForOnDestroy;

		public void OnBarkEnd(Transform actor)
		{
		}

		public void OnConversationEnd(Transform actor)
		{
		}

		public void OnSequenceEnd(Transform actor)
		{
		}

		public void OnUse(Transform actor)
		{
		}

		public void OnUse(string message)
		{
		}

		public void OnUse()
		{
		}

		public void OnTriggerEnter(Collider other)
		{
		}

		public void OnTriggerExit(Collider other)
		{
		}

		public void OnCollisionEnter(Collision collision)
		{
		}

		public void OnCollisionExit(Collision collision)
		{
		}

		public void Start()
		{
		}

		public void OnEnable()
		{
		}

		public void OnDisable()
		{
		}

		public void OnLevelWillBeUnloaded()
		{
		}

		public void OnApplicationQuit()
		{
		}

		public void OnDestroy()
		{
		}

		private IEnumerator StartAfterOneFrame()
		{
			return null;
		}

		public void TryStart(Transform actor)
		{
		}

		public void Fire()
		{
		}
	}
}

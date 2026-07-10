using System;
using System.Collections;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	public class ConditionObserver : MonoBehaviour
	{
		[Serializable]
		public class SendMessageAction
		{
			public GameObject gameObject;

			public string message;

			public string parameter;
		}

		public float frequency;

		public bool once;

		public GameObject observeGameObject;

		public Condition condition;

		public string questName;

		[QuestState]
		public QuestState questState;

		public string luaCode;

		[TextArea]
		public string sequence;

		public string alertMessage;

		public TextTable textTable;

		public SendMessageAction[] sendMessages;

		[HideInInspector]
		public bool useQuestNamePicker;

		private bool started;

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void StartObserving()
		{
		}

		private void StopObserving()
		{
		}

		private IEnumerator Observe()
		{
			return null;
		}

		public void Check()
		{
		}

		public void Check(GameObject gameObject)
		{
		}

		public void Check(string gameObjectName)
		{
		}

		public void Fire()
		{
		}
	}
}

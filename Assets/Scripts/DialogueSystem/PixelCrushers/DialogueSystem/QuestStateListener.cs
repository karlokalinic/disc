using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace PixelCrushers.DialogueSystem
{
	public class QuestStateListener : MonoBehaviour
	{
		[Serializable]
		public class QuestStateIndicatorLevel
		{
			public QuestState questState;

			public Condition condition;

			public int indicatorLevel;

			public UnityEvent onEnterState;
		}

		[Serializable]
		public class QuestEntryStateIndicatorLevel
		{
			public int entryNumber;

			public QuestState questState;

			public Condition condition;

			public int indicatorLevel;

			public UnityEvent onEnterState;
		}

		public string questName;

		public QuestStateIndicatorLevel[] questStateIndicatorLevels;

		public QuestEntryStateIndicatorLevel[] questEntryStateIndicatorLevels;

		protected QuestStateDispatcher m_questStateDispatcher;

		protected QuestStateIndicator m_questStateIndicator;

		private bool m_started;

		protected QuestStateDispatcher questStateDispatcher => null;

		protected QuestStateIndicator questStateIndicator => null;

		protected bool started
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		protected virtual void OnApplicationQuit()
		{
		}

		protected virtual IEnumerator Start()
		{
			return null;
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		public virtual void OnChange()
		{
		}

		public virtual void UpdateIndicator()
		{
		}
	}
}

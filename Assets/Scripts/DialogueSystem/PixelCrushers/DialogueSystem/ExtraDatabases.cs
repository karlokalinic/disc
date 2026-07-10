using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	public class ExtraDatabases : MonoBehaviour
	{
		public DialogueTriggerEvent addTrigger;

		public DialogueTriggerEvent removeTrigger;

		public DialogueDatabase[] databases;

		public Condition condition;

		public bool once;

		public bool onePerFrame;

		private bool m_trying;

		public static event Action addedDatabases
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action removedDatabases
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		private void TryAddDatabases(Transform interactor, bool immediate)
		{
		}

		public void AddDatabases(bool immediate)
		{
		}

		private void AddDatabasesImmediate()
		{
		}

		private IEnumerator AddDatabasesCoroutine()
		{
			return null;
		}

		private void AddDatabase(DialogueDatabase database)
		{
		}

		private void TryRemoveDatabases(Transform interactor, bool immediate)
		{
		}

		public void RemoveDatabases(bool immediate)
		{
		}

		private void RemoveDatabasesImmediate()
		{
		}

		private IEnumerator RemoveDatabasesCoroutine()
		{
			return null;
		}

		private void RemoveDatabase(DialogueDatabase database)
		{
		}

		public IEnumerator Start()
		{
			return null;
		}

		public void OnEnable()
		{
		}

		public void OnDisable()
		{
		}

		public void OnDestroy()
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
	}
}

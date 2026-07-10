using System.Collections;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	public class AlertTrigger : DialogueEventStarter
	{
		[DialogueTriggerEvent]
		public DialogueTriggerEvent trigger;

		public LocalizedTextTable localizedTextTable;

		public string message;

		public float duration;

		public Condition condition;

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
	}
}

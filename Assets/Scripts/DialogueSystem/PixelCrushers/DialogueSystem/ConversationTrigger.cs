using System.Collections;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	public class ConversationTrigger : ConversationStarter
	{
		public Transform actor;

		[DialogueTriggerEvent]
		public DialogueTriggerEvent trigger;

		public bool stopConversationOnTriggerExit;

		private float earliestTimeToAllowTriggerExit;

		private const float MarginToAllowTriggerExit = 0.2f;

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

		private void TryStartConversationOnTriggerEnter(Transform otherTransform)
		{
		}

		private void CheckOnTriggerExit(Transform otherTransform)
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

		private IEnumerator StartConversationAfterOneFrame()
		{
			return null;
		}
	}
}

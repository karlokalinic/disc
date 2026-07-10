using System.Collections;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	public class BarkTrigger : BarkStarter
	{
		public Transform target;

		[DialogueTriggerEvent]
		public DialogueTriggerEvent trigger;

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

		protected override void Start()
		{
		}

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
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

		private IEnumerator BarkAfterOneFrame()
		{
			return null;
		}
	}
}

using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	public class BarkGroupMember : MonoBehaviour
	{
		public string groupId;

		public bool evaluateIdEveryBark;

		public float forcedHideDelay;

		public bool queueBarks;

		public float minDelayBetweenQueuedBarks;

		public float maxDelayBetweenQueuedBarks;

		private string m_currentIdValue;

		private IBarkUI m_barkUI;

		private bool m_ignoreOnDisable;

		public string currentIdValue => null;

		private IBarkUI barkUI => null;

		protected virtual void Awake()
		{
		}

		protected virtual void Start()
		{
		}

		private void OnApplicationQuit()
		{
		}

		private void OnLevelWillBeUnloaded()
		{
		}

		private void OnDisable()
		{
		}

		public void GroupBark(string conversation, Transform listener, BarkHistory barkHistory, float delayTime = -1f)
		{
		}

		public void GroupBarkString(string barkText, Transform listener, string sequence, float delayTime = -1f)
		{
		}

		private void OnBarkStart(Transform listener)
		{
		}

		public void UpdateMembership()
		{
		}

		public void CancelBark()
		{
		}

		private void HideBarkNow()
		{
		}
	}
}

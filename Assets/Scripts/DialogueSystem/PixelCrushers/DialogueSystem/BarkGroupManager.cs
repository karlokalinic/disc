using System.Collections.Generic;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	public class BarkGroupManager : MonoBehaviour
	{
		private class BarkRequest
		{
			public BarkGroupMember member;

			public Transform listener;

			public string conversation;

			public BarkHistory barkHistory;

			public string barkText;

			public string sequence;

			public AbstractBarkUI barkUI;

			public float delayTime;

			public bool isPlaying;

			public BarkRequest(string conversation, BarkGroupMember member, Transform listener, BarkHistory barkHistory, float delayTime = -1f)
			{
			}

			public BarkRequest(string barkText, BarkGroupMember member, Transform listener, string sequence, float delayTime = -1f)
			{
			}

			private AbstractBarkUI GetBarkUI(BarkGroupMember member)
			{
				return null;
			}

			private float GetDelayTime(BarkGroupMember member, float delayTime)
			{
				return 0f;
			}
		}

		private static bool s_applicationIsQuitting;

		private static BarkGroupManager s_instance;

		public Dictionary<string, HashSet<BarkGroupMember>> groups;

		private Dictionary<string, Queue<BarkRequest>> queues;

		public static BarkGroupManager instance => null;

		private void OnApplicationQuit()
		{
		}

		public void AddToGroup(string groupId, BarkGroupMember member)
		{
		}

		public void RemoveFromGroup(string groupId, BarkGroupMember member)
		{
		}

		public void MutexBark(string groupId, BarkGroupMember member)
		{
		}

		public void GroupBark(string conversation, BarkGroupMember member, Transform listener, BarkHistory barkHistory, float delayTime = 0f)
		{
		}

		public void GroupBarkString(string barkText, BarkGroupMember member, Transform listener, string sequence, float delayTime = 0f)
		{
		}

		private void Enqueue(BarkRequest barkRequest)
		{
		}

		private void Update()
		{
		}
	}
}

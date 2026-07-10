using System;
using UnityEngine;
using UnityEngine.Events;

namespace PixelCrushers.DialogueSystem
{
	public class DialogueSystemEvents : MonoBehaviour
	{
		[Serializable]
		public class StringEvent : UnityEvent<string>
		{
		}

		[Serializable]
		public class TransformEvent : UnityEvent<Transform>
		{
		}

		[Serializable]
		public class SubtitleEvent : UnityEvent<Subtitle>
		{
		}

		[Serializable]
		public class ResponsesEvent : UnityEvent<Response[]>
		{
		}

		[Serializable]
		public class ConversationEvents
		{
			public TransformEvent onConversationStart;

			public TransformEvent onConversationEnd;

			public TransformEvent onConversationCancelled;

			public SubtitleEvent onConversationLine;

			public SubtitleEvent onConversationLineEnd;

			public SubtitleEvent onConversationLineCancelled;

			public ResponsesEvent onConversationResponseMenu;

			public UnityEvent onConversationResponseMenuTimeout;

			public TransformEvent onLinkedConversationStart;
		}

		[Serializable]
		public class BarkEvents
		{
			public TransformEvent onBarkStart;

			public TransformEvent onBarkEnd;

			public SubtitleEvent onBarkLine;
		}

		[Serializable]
		public class SequenceEvents
		{
			public TransformEvent onSequenceStart;

			public TransformEvent onSequenceEnd;
		}

		[Serializable]
		public class QuestEvents
		{
			public StringEvent onQuestStateChange;

			public StringEvent onQuestTrackingEnabled;

			public StringEvent onQuestTrackingDisabled;

			public UnityEvent onUpdateQuestTracker;
		}

		[Serializable]
		public class PauseEvents
		{
			public UnityEvent onDialogueSystemPause;

			public UnityEvent onDialogueSystemUnpause;
		}

		public ConversationEvents conversationEvents;

		public BarkEvents barkEvents;

		public SequenceEvents sequenceEvents;

		public QuestEvents questEvents;

		public PauseEvents pauseEvents;

		public void OnConversationStart(Transform actor)
		{
		}

		public void OnConversationEnd(Transform actor)
		{
		}

		public void OnConversationCancelled(Transform actor)
		{
		}

		public void OnConversationLine(Subtitle subtitle)
		{
		}

		public void OnConversationLineEnd(Subtitle subtitle)
		{
		}

		public void OnConversationLineCancelled(Subtitle subtitle)
		{
		}

		public void OnConversationResponseMenu(Response[] responses)
		{
		}

		public void OnConversationTimeout()
		{
		}

		public void OnLinkedConversationStart(Transform actor)
		{
		}

		public void OnBarkStart(Transform actor)
		{
		}

		public void OnBarkEnd(Transform actor)
		{
		}

		public void OnBarkLine(Subtitle subtitle)
		{
		}

		public void OnSequenceStart(Transform actor)
		{
		}

		public void OnSequenceEnd(Transform actor)
		{
		}

		public void OnQuestStateChange(string title)
		{
		}

		public void OnQuestTrackingEnabled(string title)
		{
		}

		public void OnQuestTrackingDisabled(string title)
		{
		}

		public void UpdateTracker()
		{
		}

		public void OnDialogueSystemPause()
		{
		}

		public void OnDialogueSystemUnpause()
		{
		}
	}
}

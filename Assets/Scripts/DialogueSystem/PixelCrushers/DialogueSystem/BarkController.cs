using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	public static class BarkController
	{
		private static Dictionary<Transform, int> currentBarkPriority;

		public static Sequencer LastSequencer { get; private set; }

		static BarkController()
		{
		}

		private static int GetSpeakerCurrentBarkPriority(Transform speaker)
		{
			return 0;
		}

		private static void SetSpeakerCurrentBarkPriority(Transform speaker, int priority)
		{
		}

		private static int GetEntryBarkPriority(DialogueEntry entry)
		{
			return 0;
		}

		public static IEnumerator Bark(string conversationTitle, Transform speaker, Transform listener, BarkHistory barkHistory, DialogueDatabase database = null, bool stopAtFirstValid = false)
		{
			return null;
		}

		private static Sequencer PlayBarkSequence(Subtitle subtitle, Transform speaker, Transform listener)
		{
			return null;
		}

		private static Sequencer PlayBarkSequence(string barkText, string sequence, string entrytag, Transform speaker, Transform listener)
		{
			return null;
		}

		public static IEnumerator Bark(Subtitle subtitle, Transform speaker, Transform listener, IBarkUI barkUI)
		{
			return null;
		}

		public static IEnumerator Bark(Subtitle subtitle, bool skipSequence = false)
		{
			return null;
		}

		private static bool CheckDontBarkDuringConversation()
		{
			return false;
		}

		private static void InformParticipants(string message, Transform speaker, Transform listener)
		{
		}

		private static void InformParticipantsLine(string message, Transform speaker, Subtitle subtitle)
		{
		}
	}
}

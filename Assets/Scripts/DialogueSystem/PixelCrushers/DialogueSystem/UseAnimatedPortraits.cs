using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace PixelCrushers.DialogueSystem
{
	public class UseAnimatedPortraits : MonoBehaviour
	{
		private UnityUIDialogueUI dialogueUI;

		private Animator npcPortraitAnimator;

		private Animator npcReminderPortraitAnimator;

		private Animator pcPortraitAnimator;

		private Animator otherAnimator;

		private Dictionary<Transform, AnimatedPortrait> animatedPortraits;

		private Transform lastSpeaker;

		public void OnConversationLine(Subtitle subtitle)
		{
		}

		private IEnumerator SetAnimatorAtEndOfFrame(Subtitle subtitle)
		{
			return null;
		}

		public void OnConversationResponseMenu(Response[] responses)
		{
		}

		public void OnConversationEnd(Transform actor)
		{
		}

		private bool FindDialogueUI()
		{
			return false;
		}

		private void SetAnimatorController(Image image, Transform speaker, ref Animator animator)
		{
		}
	}
}

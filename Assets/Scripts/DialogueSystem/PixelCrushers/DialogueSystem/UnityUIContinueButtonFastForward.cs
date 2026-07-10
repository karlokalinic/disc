using UnityEngine;
using UnityEngine.UI;

namespace PixelCrushers.DialogueSystem
{
	public class UnityUIContinueButtonFastForward : MonoBehaviour
	{
		public UnityUIDialogueUI dialogueUI;

		public UnityUITypewriterEffect typewriterEffect;

		public bool hideContinueButtonOnContinue;

		private Button continueButton;

		public virtual void Awake()
		{
		}

		public virtual void OnFastForward()
		{
		}
	}
}

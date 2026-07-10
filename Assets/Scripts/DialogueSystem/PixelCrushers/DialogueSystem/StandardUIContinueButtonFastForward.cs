using UnityEngine;
using UnityEngine.UI;

namespace PixelCrushers.DialogueSystem
{
	public class StandardUIContinueButtonFastForward : MonoBehaviour
	{
		public StandardDialogueUI dialogueUI;

		public AbstractTypewriterEffect typewriterEffect;

		public bool hideContinueButtonOnContinue;

		private Button continueButton;

		private AbstractDialogueUI m_runtimeDialogueUI;

		private AbstractDialogueUI runtimeDialogueUI => null;

		public virtual void Awake()
		{
		}

		public virtual void OnFastForward()
		{
		}
	}
}

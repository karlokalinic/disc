using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	public class OverrideUnityUIDialogueControls : MonoBehaviour
	{
		public UnityUISubtitleControls subtitle;

		public UnityUISubtitleControls subtitleReminder;

		public UnityUIResponseMenuControls responseMenu;

		private bool checkedContinueButton;

		private void Awake()
		{
		}

		public virtual void Start()
		{
		}

		public virtual void ApplyToDialogueUI(UnityUIDialogueUI ui)
		{
		}
	}
}

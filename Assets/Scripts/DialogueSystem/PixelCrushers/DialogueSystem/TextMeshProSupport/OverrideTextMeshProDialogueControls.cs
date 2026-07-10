using UnityEngine;

namespace PixelCrushers.DialogueSystem.TextMeshProSupport
{
	public class OverrideTextMeshProDialogueControls : MonoBehaviour
	{
		public TextMeshProSubtitleControls subtitle;

		public TextMeshProSubtitleControls subtitleReminder;

		public TextMeshProResponseMenuControls responseMenu;

		private bool checkedContinueButton;

		public virtual void Start()
		{
		}

		public virtual void ApplyToDialogueUI(TextMeshProDialogueUI ui)
		{
		}
	}
}

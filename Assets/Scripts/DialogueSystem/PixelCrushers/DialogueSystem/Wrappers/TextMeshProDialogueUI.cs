using PixelCrushers.DialogueSystem.TextMeshProSupport;
using UnityEngine;

namespace PixelCrushers.DialogueSystem.Wrappers
{
	public class TextMeshProDialogueUI : PixelCrushers.DialogueSystem.TextMeshProSupport.TextMeshProDialogueUI
	{
		[SerializeField]
		protected TextMeshProDialogueControls wrappedDialogue;

		protected TextMeshProResponseMenuControls wrappedResponseMenu;

		public TextMeshProResponseMenuControls WrappedResponseMenu => null;

		protected override void FindControls()
		{
		}

		public override void Awake()
		{
		}
	}
}

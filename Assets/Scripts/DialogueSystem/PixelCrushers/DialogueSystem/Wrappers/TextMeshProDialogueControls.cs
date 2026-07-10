using System;
using PixelCrushers.DialogueSystem.TextMeshProSupport;

namespace PixelCrushers.DialogueSystem.Wrappers
{
	[Serializable]
	public class TextMeshProDialogueControls : PixelCrushers.DialogueSystem.TextMeshProSupport.TextMeshProDialogueControls
	{
		public TextMeshProResponseMenuControls wrappedResponseMenu;

		public void Initialize()
		{
		}
	}
}

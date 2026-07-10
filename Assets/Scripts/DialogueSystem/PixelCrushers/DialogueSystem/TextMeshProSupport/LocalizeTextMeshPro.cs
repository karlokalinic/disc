using TMPro;

namespace PixelCrushers.DialogueSystem.TextMeshProSupport
{
	public class LocalizeTextMeshPro : LocalizeUI
	{
		private TextMeshPro m_textMeshPro;

		private bool m_lookedForTMPNotUGUI;

		private bool m_lookedForTMPUGUI;

		public TextMeshPro textMeshPro
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override void UpdateText()
		{
		}
	}
}

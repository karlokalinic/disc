using DiscoPages.Elements.Dialogue;
using PagesSystem;
using PixelCrushers.DialogueSystem;

namespace Pages.Gameplay.Dialogue
{
	public class DialogueNavigationParameters : NavigationParameters
	{
		public ConversationLoggerPageSystem conversationLogger;

		public DialogueSystemControllerPageSystem dialogueSystem;

		public DialogueNavigationParameters(ConversationLoggerPageSystem conversationLogger, DialogueSystemControllerPageSystem dialogueSystem)
		{
		}
	}
}

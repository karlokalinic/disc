namespace PixelCrushers.DialogueSystem
{
	public class Response
	{
		public FormattedText formattedText;

		public DialogueEntry destinationEntry;

		public bool enabled;

		public Response(FormattedText formattedText, DialogueEntry destinationEntry, bool enabled = true)
		{
		}
	}
}

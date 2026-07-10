using System;

namespace PixelCrushers.DialogueSystem
{
	public class SelectedResponseEventArgs : EventArgs
	{
		public Response response;

		public DialogueEntry DestinationEntry => null;

		public SelectedResponseEventArgs(Response response)
		{
		}
	}
}

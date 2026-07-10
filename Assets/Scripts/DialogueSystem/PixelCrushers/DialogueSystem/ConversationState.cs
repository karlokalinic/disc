namespace PixelCrushers.DialogueSystem
{
	public class ConversationState
	{
		public Subtitle subtitle;

		public Response[] npcResponses;

		public Response[] pcResponses;

		public bool hasNPCResponse => false;

		public Response firstNPCResponse => null;

		public bool hasPCResponses => false;

		public bool hasPCAutoResponse => false;

		public bool hasForceAutoResponse => false;

		public Response pcAutoResponse => null;

		public bool hasAnyResponses => false;

		public bool isGroup { get; set; }

		public bool HasNPCResponse => false;

		public Response FirstNPCResponse => null;

		public bool HasPCResponses => false;

		public bool HasPCAutoResponse => false;

		public Response PCAutoResponse => null;

		public bool HasAnyResponses => false;

		public bool IsGroup
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public ConversationState(Subtitle subtitle, Response[] npcResponses, Response[] pcResponses, bool isGroup = false)
		{
		}

		public DialogueEntry GetRandomNPCEntry()
		{
			return null;
		}
	}
}

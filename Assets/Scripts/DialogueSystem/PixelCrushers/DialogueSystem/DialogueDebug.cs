namespace PixelCrushers.DialogueSystem
{
	public static class DialogueDebug
	{
		public enum DebugLevel
		{
			None = 0,
			Error = 1,
			Warning = 2,
			Info = 3
		}

		public const string Prefix = "Dialogue System";

		public static DebugLevel level { get; set; }

		public static bool logInfo => false;

		public static bool logWarnings => false;

		public static bool logErrors => false;

		public static DebugLevel Level
		{
			get
			{
				return default(DebugLevel);
			}
			set
			{
			}
		}

		public static bool LogInfo => false;

		public static bool LogWarnings => false;

		public static bool LogErrors => false;

		static DialogueDebug()
		{
		}
	}
}

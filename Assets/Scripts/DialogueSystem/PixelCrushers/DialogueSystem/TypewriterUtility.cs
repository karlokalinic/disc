namespace PixelCrushers.DialogueSystem
{
	public static class TypewriterUtility
	{
		public static AbstractTypewriterEffect GetTypewriter(UITextField textField)
		{
			return null;
		}

		public static bool HasTypewriter(UITextField textField)
		{
			return false;
		}

		public static float GetTypewriterSpeed(AbstractTypewriterEffect typewriter)
		{
			return 0f;
		}

		public static float GetTypewriterSpeed(UITextField textField)
		{
			return 0f;
		}

		public static void SetTypewriterSpeed(UITextField textField, float charactersPerSecond)
		{
		}

		public static void StartTyping(UITextField textField, string text, int fromIndex = 0)
		{
		}

		public static void StopTyping(UITextField textField)
		{
		}
	}
}

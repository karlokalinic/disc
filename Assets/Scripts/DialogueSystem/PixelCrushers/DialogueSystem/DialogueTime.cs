using System.Collections;

namespace PixelCrushers.DialogueSystem
{
	public static class DialogueTime
	{
		public enum TimeMode
		{
			Realtime = 0,
			Gameplay = 1,
			Custom = 2
		}

		private static float m_customTime;

		private static bool m_isPaused;

		private static float s_realtimeWhenPaused;

		private static float s_totalRealtimePaused;

		public static TimeMode mode { get; set; }

		public static float time
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public static bool isPaused
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static TimeMode Mode
		{
			get
			{
				return default(TimeMode);
			}
			set
			{
			}
		}

		public static bool IsPaused
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		static DialogueTime()
		{
		}

		public static IEnumerator WaitForSeconds(float seconds)
		{
			return null;
		}
	}
}

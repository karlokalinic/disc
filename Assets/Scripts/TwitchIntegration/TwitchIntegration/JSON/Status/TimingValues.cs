using System;

namespace TwitchIntegration.JSON.Status
{
	[Serializable]
	public class TimingValues
	{
		public class Dialogue
		{
			public int poll_duration;

			public override string ToString()
			{
				return null;
			}
		}

		public class Meditation
		{
			public int poll_duration;

			public int buff_duration;

			public int cooldown;

			public override string ToString()
			{
				return null;
			}
		}

		public Dialogue dialogue;

		public Meditation meditation;

		public override string ToString()
		{
			return null;
		}
	}
}

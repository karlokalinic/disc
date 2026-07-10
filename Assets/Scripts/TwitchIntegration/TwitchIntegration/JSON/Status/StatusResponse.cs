using System;

namespace TwitchIntegration.JSON.Status
{
	[Serializable]
	public class StatusResponse
	{
		public bool game_connection_success;

		public string version;

		public TimingValues timing_values;

		public override string ToString()
		{
			return null;
		}
	}
}

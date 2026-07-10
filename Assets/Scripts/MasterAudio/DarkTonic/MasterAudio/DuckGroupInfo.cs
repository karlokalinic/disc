using System;

namespace DarkTonic.MasterAudio
{
	[Serializable]
	public class DuckGroupInfo
	{
		public string soundType;

		public float riseVolStart;

		public float unduckTime;

		public float duckedVolumeMultiplier;
	}
}

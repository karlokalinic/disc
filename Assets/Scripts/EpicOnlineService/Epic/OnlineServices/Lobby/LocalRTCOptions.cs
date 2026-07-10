namespace Epic.OnlineServices.Lobby
{
	public class LocalRTCOptions : ISettable
	{
		public uint Flags { get; set; }

		public bool UseManualAudioInput { get; set; }

		public bool UseManualAudioOutput { get; set; }

		public bool LocalAudioDeviceInputStartsMuted { get; set; }

		internal void Set(LocalRTCOptionsInternal? other)
		{
		}

		public void Set(object other)
		{
		}
	}
}

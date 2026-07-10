namespace Epic.OnlineServices.RTCAudio
{
	public class AudioBuffer : ISettable
	{
		public short[] Frames { get; set; }

		public uint SampleRate { get; set; }

		public uint Channels { get; set; }

		internal void Set(AudioBufferInternal? other)
		{
		}

		public void Set(object other)
		{
		}
	}
}

namespace Epic.OnlineServices.Platform
{
	public class WindowsRTCOptionsPlatformSpecificOptions : ISettable
	{
		public string XAudio29DllPath { get; set; }

		internal void Set(WindowsRTCOptionsPlatformSpecificOptionsInternal? other)
		{
		}

		public void Set(object other)
		{
		}
	}
}

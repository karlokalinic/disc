namespace Epic.OnlineServices.Platform
{
	public class WindowsRTCOptions : ISettable
	{
		public WindowsRTCOptionsPlatformSpecificOptions PlatformSpecificOptions { get; set; }

		internal void Set(WindowsRTCOptionsInternal? other)
		{
		}

		public void Set(object other)
		{
		}
	}
}

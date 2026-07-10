using System;

namespace Epic.OnlineServices.Platform
{
	public class RTCOptions : ISettable
	{
		public IntPtr PlatformSpecificOptions { get; set; }

		internal void Set(RTCOptionsInternal? other)
		{
		}

		public void Set(object other)
		{
		}
	}
}

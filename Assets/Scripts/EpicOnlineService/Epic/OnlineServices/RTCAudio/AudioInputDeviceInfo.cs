namespace Epic.OnlineServices.RTCAudio
{
	public class AudioInputDeviceInfo : ISettable
	{
		public bool DefaultDevice { get; set; }

		public string DeviceId { get; set; }

		public string DeviceName { get; set; }

		internal void Set(AudioInputDeviceInfoInternal? other)
		{
		}

		public void Set(object other)
		{
		}
	}
}

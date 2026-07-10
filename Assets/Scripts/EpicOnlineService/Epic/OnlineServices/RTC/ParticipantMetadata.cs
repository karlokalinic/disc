namespace Epic.OnlineServices.RTC
{
	public class ParticipantMetadata : ISettable
	{
		public string Key { get; set; }

		public string Value { get; set; }

		internal void Set(ParticipantMetadataInternal? other)
		{
		}

		public void Set(object other)
		{
		}
	}
}

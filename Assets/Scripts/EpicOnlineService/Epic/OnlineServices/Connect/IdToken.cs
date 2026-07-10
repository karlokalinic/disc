namespace Epic.OnlineServices.Connect
{
	public class IdToken : ISettable
	{
		public ProductUserId ProductUserId { get; set; }

		public string JsonWebToken { get; set; }

		internal void Set(IdTokenInternal? other)
		{
		}

		public void Set(object other)
		{
		}
	}
}

namespace Epic.OnlineServices.RTCAdmin
{
	public class UserToken : ISettable
	{
		public ProductUserId ProductUserId { get; set; }

		public string Token { get; set; }

		internal void Set(UserTokenInternal? other)
		{
		}

		public void Set(object other)
		{
		}
	}
}

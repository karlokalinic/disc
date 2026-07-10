namespace Epic.OnlineServices.Auth
{
	public class IdToken : ISettable
	{
		public EpicAccountId AccountId { get; set; }

		public string JsonWebToken { get; set; }

		internal void Set(IdTokenInternal? other)
		{
		}

		public void Set(object other)
		{
		}
	}
}

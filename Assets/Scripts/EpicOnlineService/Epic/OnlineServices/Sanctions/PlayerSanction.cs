namespace Epic.OnlineServices.Sanctions
{
	public class PlayerSanction : ISettable
	{
		public long TimePlaced { get; set; }

		public string Action { get; set; }

		public long TimeExpires { get; set; }

		public string ReferenceId { get; set; }

		internal void Set(PlayerSanctionInternal? other)
		{
		}

		public void Set(object other)
		{
		}
	}
}

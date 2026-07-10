namespace Epic.OnlineServices.KWS
{
	public class PermissionStatus : ISettable
	{
		public string Name { get; set; }

		public KWSPermissionStatus Status { get; set; }

		internal void Set(PermissionStatusInternal? other)
		{
		}

		public void Set(object other)
		{
		}
	}
}

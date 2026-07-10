namespace Epic.OnlineServices.AntiCheatCommon
{
	public class Vec3f : ISettable
	{
		public float x { get; set; }

		public float y { get; set; }

		public float z { get; set; }

		internal void Set(Vec3fInternal? other)
		{
		}

		public void Set(object other)
		{
		}
	}
}

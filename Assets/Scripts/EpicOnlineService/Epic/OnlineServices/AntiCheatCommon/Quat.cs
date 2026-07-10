namespace Epic.OnlineServices.AntiCheatCommon
{
	public class Quat : ISettable
	{
		public float w { get; set; }

		public float x { get; set; }

		public float y { get; set; }

		public float z { get; set; }

		internal void Set(QuatInternal? other)
		{
		}

		public void Set(object other)
		{
		}
	}
}

namespace Epic.OnlineServices.ProgressionSnapshot
{
	public class SubmitSnapshotCallbackInfo : ICallbackInfo, ISettable
	{
		public Result ResultCode { get; private set; }

		public uint SnapshotId { get; private set; }

		public object ClientData { get; private set; }

		public Result? GetResultCode()
		{
			return null;
		}

		internal void Set(SubmitSnapshotCallbackInfoInternal? other)
		{
		}

		public void Set(object other)
		{
		}
	}
}

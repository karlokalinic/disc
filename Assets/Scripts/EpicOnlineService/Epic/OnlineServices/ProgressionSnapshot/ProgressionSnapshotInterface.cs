using System;

namespace Epic.OnlineServices.ProgressionSnapshot
{
	public sealed class ProgressionSnapshotInterface : Handle
	{
		public const int AddprogressionApiLatest = 1;

		public const int BeginsnapshotApiLatest = 1;

		public const int DeletesnapshotApiLatest = 1;

		public const int EndsnapshotApiLatest = 1;

		public const int InvalidProgressionsnapshotid = 0;

		public const int SubmitsnapshotApiLatest = 1;

		public ProgressionSnapshotInterface()
		{
		}

		public ProgressionSnapshotInterface(IntPtr innerHandle)
		{
		}

		public Result AddProgression(AddProgressionOptions options)
		{
			return default(Result);
		}

		public Result BeginSnapshot(BeginSnapshotOptions options, out uint outSnapshotId)
		{
			outSnapshotId = default(uint);
			return default(Result);
		}

		public void DeleteSnapshot(DeleteSnapshotOptions options, object clientData, OnDeleteSnapshotCallback completionDelegate)
		{
		}

		public Result EndSnapshot(EndSnapshotOptions options)
		{
			return default(Result);
		}

		public void SubmitSnapshot(SubmitSnapshotOptions options, object clientData, OnSubmitSnapshotCallback completionDelegate)
		{
		}

		internal static void OnDeleteSnapshotCallbackInternalImplementation(IntPtr data)
		{
		}

		internal static void OnSubmitSnapshotCallbackInternalImplementation(IntPtr data)
		{
		}
	}
}

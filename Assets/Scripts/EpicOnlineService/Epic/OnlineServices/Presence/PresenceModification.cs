using System;

namespace Epic.OnlineServices.Presence
{
	public sealed class PresenceModification : Handle
	{
		public const int PresencemodificationDatarecordidApiLatest = 1;

		public const int PresencemodificationDeletedataApiLatest = 1;

		public const int PresencemodificationJoininfoMaxLength = 255;

		public const int PresencemodificationSetdataApiLatest = 1;

		public const int PresencemodificationSetjoininfoApiLatest = 1;

		public const int PresencemodificationSetrawrichtextApiLatest = 1;

		public const int PresencemodificationSetstatusApiLatest = 1;

		public PresenceModification()
		{
		}

		public PresenceModification(IntPtr innerHandle)
		{
		}

		public Result DeleteData(PresenceModificationDeleteDataOptions options)
		{
			return default(Result);
		}

		public void Release()
		{
		}

		public Result SetData(PresenceModificationSetDataOptions options)
		{
			return default(Result);
		}

		public Result SetJoinInfo(PresenceModificationSetJoinInfoOptions options)
		{
			return default(Result);
		}

		public Result SetRawRichText(PresenceModificationSetRawRichTextOptions options)
		{
			return default(Result);
		}

		public Result SetStatus(PresenceModificationSetStatusOptions options)
		{
			return default(Result);
		}
	}
}

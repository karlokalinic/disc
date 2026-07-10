using System;

namespace Epic.OnlineServices.Presence
{
	public sealed class PresenceInterface : Handle
	{
		public const int AddnotifyjoingameacceptedApiLatest = 2;

		public const int AddnotifyonpresencechangedApiLatest = 1;

		public const int CopypresenceApiLatest = 2;

		public const int CreatepresencemodificationApiLatest = 1;

		public const int DataMaxKeyLength = 64;

		public const int DataMaxKeys = 32;

		public const int DataMaxValueLength = 255;

		public const int DatarecordApiLatest = 1;

		public const int DeletedataApiLatest = 1;

		public const int GetjoininfoApiLatest = 1;

		public const int HaspresenceApiLatest = 1;

		public const int InfoApiLatest = 2;

		public const int QuerypresenceApiLatest = 1;

		public const int RichTextMaxValueLength = 255;

		public const int SetdataApiLatest = 1;

		public const int SetpresenceApiLatest = 1;

		public const int SetrawrichtextApiLatest = 1;

		public const int SetstatusApiLatest = 1;

		public PresenceInterface()
		{
		}

		public PresenceInterface(IntPtr innerHandle)
		{
		}

		public ulong AddNotifyJoinGameAccepted(AddNotifyJoinGameAcceptedOptions options, object clientData, OnJoinGameAcceptedCallback notificationFn)
		{
			return 0uL;
		}

		public ulong AddNotifyOnPresenceChanged(AddNotifyOnPresenceChangedOptions options, object clientData, OnPresenceChangedCallback notificationHandler)
		{
			return 0uL;
		}

		public Result CopyPresence(CopyPresenceOptions options, out Info outPresence)
		{
			outPresence = null;
			return default(Result);
		}

		public Result CreatePresenceModification(CreatePresenceModificationOptions options, out PresenceModification outPresenceModificationHandle)
		{
			outPresenceModificationHandle = null;
			return default(Result);
		}

		public Result GetJoinInfo(GetJoinInfoOptions options, out string outBuffer)
		{
			outBuffer = null;
			return default(Result);
		}

		public bool HasPresence(HasPresenceOptions options)
		{
			return false;
		}

		public void QueryPresence(QueryPresenceOptions options, object clientData, OnQueryPresenceCompleteCallback completionDelegate)
		{
		}

		public void RemoveNotifyJoinGameAccepted(ulong inId)
		{
		}

		public void RemoveNotifyOnPresenceChanged(ulong notificationId)
		{
		}

		public void SetPresence(SetPresenceOptions options, object clientData, SetPresenceCompleteCallback completionDelegate)
		{
		}

		internal static void OnJoinGameAcceptedCallbackInternalImplementation(IntPtr data)
		{
		}

		internal static void OnPresenceChangedCallbackInternalImplementation(IntPtr data)
		{
		}

		internal static void OnQueryPresenceCompleteCallbackInternalImplementation(IntPtr data)
		{
		}

		internal static void SetPresenceCompleteCallbackInternalImplementation(IntPtr data)
		{
		}
	}
}

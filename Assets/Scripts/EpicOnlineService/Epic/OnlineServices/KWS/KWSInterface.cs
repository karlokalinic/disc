using System;

namespace Epic.OnlineServices.KWS
{
	public sealed class KWSInterface : Handle
	{
		public const int AddnotifypermissionsupdatereceivedApiLatest = 1;

		public const int CopypermissionbyindexApiLatest = 1;

		public const int CreateuserApiLatest = 1;

		public const int GetpermissionbykeyApiLatest = 1;

		public const int GetpermissionscountApiLatest = 1;

		public const int MaxPermissionLength = 32;

		public const int MaxPermissions = 16;

		public const int PermissionstatusApiLatest = 1;

		public const int QueryagegateApiLatest = 1;

		public const int QuerypermissionsApiLatest = 1;

		public const int RequestpermissionsApiLatest = 1;

		public const int UpdateparentemailApiLatest = 1;

		public KWSInterface()
		{
		}

		public KWSInterface(IntPtr innerHandle)
		{
		}

		public ulong AddNotifyPermissionsUpdateReceived(AddNotifyPermissionsUpdateReceivedOptions options, object clientData, OnPermissionsUpdateReceivedCallback notificationFn)
		{
			return 0uL;
		}

		public Result CopyPermissionByIndex(CopyPermissionByIndexOptions options, out PermissionStatus outPermission)
		{
			outPermission = null;
			return default(Result);
		}

		public void CreateUser(CreateUserOptions options, object clientData, OnCreateUserCallback completionDelegate)
		{
		}

		public Result GetPermissionByKey(GetPermissionByKeyOptions options, out KWSPermissionStatus outPermission)
		{
			outPermission = default(KWSPermissionStatus);
			return default(Result);
		}

		public int GetPermissionsCount(GetPermissionsCountOptions options)
		{
			return 0;
		}

		public void QueryAgeGate(QueryAgeGateOptions options, object clientData, OnQueryAgeGateCallback completionDelegate)
		{
		}

		public void QueryPermissions(QueryPermissionsOptions options, object clientData, OnQueryPermissionsCallback completionDelegate)
		{
		}

		public void RemoveNotifyPermissionsUpdateReceived(ulong inId)
		{
		}

		public void RequestPermissions(RequestPermissionsOptions options, object clientData, OnRequestPermissionsCallback completionDelegate)
		{
		}

		public void UpdateParentEmail(UpdateParentEmailOptions options, object clientData, OnUpdateParentEmailCallback completionDelegate)
		{
		}

		internal static void OnCreateUserCallbackInternalImplementation(IntPtr data)
		{
		}

		internal static void OnPermissionsUpdateReceivedCallbackInternalImplementation(IntPtr data)
		{
		}

		internal static void OnQueryAgeGateCallbackInternalImplementation(IntPtr data)
		{
		}

		internal static void OnQueryPermissionsCallbackInternalImplementation(IntPtr data)
		{
		}

		internal static void OnRequestPermissionsCallbackInternalImplementation(IntPtr data)
		{
		}

		internal static void OnUpdateParentEmailCallbackInternalImplementation(IntPtr data)
		{
		}
	}
}

using System;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public class IChat : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		internal IChat(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		internal static HandleRef getCPtr(IChat obj)
		{
			return default(HandleRef);
		}

		~IChat()
		{
		}

		public virtual void Dispose()
		{
		}

		public virtual void RequestChatRoomWithUser(GalaxyID userID, IChatRoomWithUserRetrieveListener listener)
		{
		}

		public virtual void RequestChatRoomWithUser(GalaxyID userID)
		{
		}

		public virtual void RequestChatRoomMessages(ulong chatRoomID, uint limit, ulong referenceMessageID, IChatRoomMessagesRetrieveListener listener)
		{
		}

		public virtual void RequestChatRoomMessages(ulong chatRoomID, uint limit, ulong referenceMessageID)
		{
		}

		public virtual void RequestChatRoomMessages(ulong chatRoomID, uint limit)
		{
		}

		public virtual uint SendChatRoomMessage(ulong chatRoomID, string msg, IChatRoomMessageSendListener listener)
		{
			return 0u;
		}

		public virtual uint SendChatRoomMessage(ulong chatRoomID, string msg)
		{
			return 0u;
		}

		public virtual uint GetChatRoomMessageByIndex(uint index, ref ulong messageID, ref ChatMessageType messageType, ref GalaxyID senderID, ref uint sendTime, out string buffer, uint bufferLength)
		{
			buffer = null;
			return 0u;
		}

		public virtual uint GetChatRoomMemberCount(ulong chatRoomID)
		{
			return 0u;
		}

		public virtual GalaxyID GetChatRoomMemberUserIDByIndex(ulong chatRoomID, uint index)
		{
			return null;
		}

		public virtual uint GetChatRoomUnreadMessageCount(ulong chatRoomID)
		{
			return 0u;
		}

		public virtual void MarkChatRoomAsRead(ulong chatRoomID)
		{
		}
	}
}

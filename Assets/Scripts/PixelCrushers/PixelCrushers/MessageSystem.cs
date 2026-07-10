using System.Collections.Generic;
using UnityEngine;

namespace PixelCrushers
{
	public static class MessageSystem
	{
		public class ListenerInfo
		{
			public IMessageHandler listener;

			public string message;

			public string parameter;

			public bool removed;

			public ListenerInfo()
			{
			}

			public ListenerInfo(IMessageHandler listener, string message, string parameter)
			{
			}

			public void Assign(IMessageHandler listener, string message, string parameter)
			{
			}

			public void Clear()
			{
			}
		}

		private static List<ListenerInfo> s_listenerInfo;

		private static Pool<ListenerInfo> s_listenerInfoPool;

		private static HashSet<GameObject> s_sendersToLog;

		private static HashSet<GameObject> s_listenersToLog;

		private static bool s_sendInEditMode;

		private static bool s_debug;

		private static int s_sendMessageDepth;

		public static bool sendInEditMode
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static bool debug
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		private static List<ListenerInfo> listenerInfo => null;

		private static Pool<ListenerInfo> listenerInfoPool => null;

		private static int sendMessageDepth
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static bool IsListenerRegistered(IMessageHandler listener, string message, string parameter)
		{
			return false;
		}

		public static void AddListener(IMessageHandler listener, string message, string parameter)
		{
		}

		public static void AddListener(IMessageHandler listener, StringField message, StringField parameter)
		{
		}

		public static void AddListener(IMessageHandler listener, StringField message, string parameter)
		{
		}

		public static void AddListener(IMessageHandler listener, string message, StringField parameter)
		{
		}

		public static void RemoveListener(IMessageHandler listener, string message, string parameter)
		{
		}

		private static void RemoveMarkedListenerInfo()
		{
		}

		public static void RemoveListener(IMessageHandler listener, StringField message, StringField parameter)
		{
		}

		public static void RemoveListener(IMessageHandler listener, StringField message, string parameter)
		{
		}

		public static void RemoveListener(IMessageHandler listener, string message, StringField parameter)
		{
		}

		public static void RemoveListener(IMessageHandler listener)
		{
		}

		public static void LogWhenSendingMessages(GameObject sender)
		{
		}

		public static void StopLoggingWhenSendingMessages(GameObject sender)
		{
		}

		public static void LogWhenReceivingMessages(GameObject listener)
		{
		}

		public static void StopLoggingWhenReceivingMessages(GameObject listener)
		{
		}

		private static bool ShouldLogSender(object sender)
		{
			return false;
		}

		private static bool ShouldLogReceiver(IMessageHandler receiver)
		{
			return false;
		}

		public static void SendMessageWithTarget(object sender, object target, string message, string parameter, params object[] values)
		{
		}

		public static void SendMessageWithTarget(object sender, object target, StringField message, string parameter, params object[] values)
		{
		}

		public static void SendMessageWithTarget(object sender, object target, StringField message, StringField parameter, params object[] values)
		{
		}

		public static void SendMessageWithTarget(object sender, object target, string message, StringField parameter, params object[] values)
		{
		}

		public static void SendMessage(object sender, string message, string parameter, params object[] values)
		{
		}

		public static void SendMessage(object sender, StringField message, StringField parameter, params object[] values)
		{
		}

		public static void SendMessage(object sender, StringField message, string parameter, params object[] values)
		{
		}

		public static void SendMessage(object sender, string message, StringField parameter, params object[] values)
		{
		}

		public static void SendCompositeMessage(object sender, string message)
		{
		}
	}
}

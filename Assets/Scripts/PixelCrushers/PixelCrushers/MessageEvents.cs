using System;
using UnityEngine;

namespace PixelCrushers
{
	[Serializable]
	public class MessageEvents : MonoBehaviour, IMessageHandler
	{
		[Serializable]
		public class MessageEvent
		{
			public GameObject requiredSender;

			public GameObject requiredTarget;

			public StringField message;

			public StringField parameter;

			public MessageArgsEvent onMessage;
		}

		[Serializable]
		public class MessageToSend
		{
			public GameObject target;

			public StringField message;

			public StringField parameter;
		}

		[SerializeField]
		private MessageEvent[] m_messagesToListenFor;

		[SerializeField]
		private MessageToSend[] m_messagesToSend;

		public MessageEvent[] messagesToListenFor
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public MessageToSend[] messagesToSend
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void OnMessage(MessageArgs messageArgs)
		{
		}

		private bool IsParticipantOk(GameObject requiredParticipant, object actualParticipant)
		{
			return false;
		}

		public void SendToMessageSystem(int index)
		{
		}
	}
}

using UnityEngine;

namespace PixelCrushers.DialogueSystem.SequencerCommands
{
	public abstract class SequencerCommand : MonoBehaviour
	{
		[HideInInspector]
		public bool isPlaying;

		private Sequencer m_sequencer;

		private string[] m_parameters;

		private string m_endMessage;

		private Transform m_speaker;

		private Transform m_listener;

		protected Sequencer sequencer
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		protected string[] parameters
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public string endMessage
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		protected Transform speaker => null;

		protected Transform listener => null;

		public bool IsPlaying
		{
			get
			{
				return false;
			}
			protected set
			{
			}
		}

		protected Sequencer Sequencer
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		protected string[] Parameters
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public void Initialize(Sequencer sequencer, string endMessage, Transform speaker, Transform listener, params string[] parameters)
		{
		}

		public void Initialize(Sequencer sequencer, Transform speaker, Transform listener, params string[] parameters)
		{
		}

		protected void Stop()
		{
		}

		protected Transform GetSubject(string specifier, Transform defaultSubject = null)
		{
			return null;
		}

		protected Transform GetSubject(int i, Transform defaultSubject = null)
		{
			return null;
		}

		protected string GetParameter(int i, string defaultValue = null)
		{
			return null;
		}

		protected T GetParameterAs<T>(int i, T defaultValue)
		{
			return default(T);
		}

		protected float GetParameterAsFloat(int i, float defaultValue = 0f)
		{
			return 0f;
		}

		protected int GetParameterAsInt(int i, int defaultValue = 0)
		{
			return 0;
		}

		protected bool GetParameterAsBool(int i, bool defaultValue = false)
		{
			return false;
		}

		protected string GetParameters()
		{
			return null;
		}

		protected bool IsAudioMuted()
		{
			return false;
		}
	}
}

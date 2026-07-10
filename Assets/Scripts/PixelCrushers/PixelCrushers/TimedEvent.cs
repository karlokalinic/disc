using System.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace PixelCrushers
{
	public class TimedEvent : MonoBehaviour
	{
		public enum TimingMode
		{
			Seconds = 0,
			Frames = 1
		}

		[SerializeField]
		private TimingMode m_mode;

		[SerializeField]
		private float m_duration;

		[SerializeField]
		private int m_frames;

		[SerializeField]
		private bool m_activateOnStart;

		[SerializeField]
		private UnityEvent m_onTimeReached;

		public TimingMode mode
		{
			get
			{
				return default(TimingMode);
			}
			set
			{
			}
		}

		public float duration
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public int frames
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool activateOnStart
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		private UnityEvent onTimeReached
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected virtual void Start()
		{
		}

		protected virtual void OnDisable()
		{
		}

		public virtual void StartTimer()
		{
		}

		public virtual void StartTimer(float duration)
		{
		}

		private IEnumerator CountFrames()
		{
			return null;
		}

		protected virtual void CancelTimer()
		{
		}

		protected virtual void TimeReached()
		{
		}

		public void DestroyUnityObject(Object o)
		{
		}
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Voidforge
{
	public class Timer : IDisposable
	{
		private UpdateType _updateType;

		private int _priority;

		private bool _enabled;

		private float _duration;

		private float _time;

		private float? _ratio;

		private static Stack<Timer> idleTimers;

		public bool countingDown { get; set; }

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

		public bool Enabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool ignoreTimeScale { get; set; }

		public int priority
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public UpdateType updateType
		{
			get
			{
				return default(UpdateType);
			}
			set
			{
			}
		}

		public float ratio => 0f;

		public float remaining => 0f;

		public bool repeating { get; set; }

		public float time
		{
			get
			{
				return 0f;
			}
			protected set
			{
			}
		}

		public event Action<Timer> onChange
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<Timer> onFinish
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public void Dispose()
		{
		}

		protected Timer()
		{
		}

		protected void OnUpdate()
		{
		}

		public static Timer Create(float duration, Action<Timer> callback = null, bool countingDown = true, bool enable = true)
		{
			return null;
		}

		public static Timer Schedule(float delay, Action Action)
		{
			return null;
		}

		public static Timer ScheduleRealtime(float delay, Action Action)
		{
			return null;
		}
	}
}

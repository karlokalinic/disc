using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Voidforge
{
	public abstract class Tween : VoidElement
	{
		public class Stats
		{
			private float _tweenDuration;

			private float _totalDuration;

			public float tweenDuration
			{
				get
				{
					return 0f;
				}
				set
				{
				}
			}

			public float tweenDurationR { get; protected set; }

			public float totalDuration
			{
				get
				{
					return 0f;
				}
				set
				{
				}
			}

			public float totalDurationR { get; protected set; }

			public float delayStart { get; set; }

			public Stats(object subject)
			{
			}
		}

		[Serializable]
		public class Target
		{
			public GameObject value;

			public GameObject Item => null;
		}

		public interface IBeforePlaying
		{
			void BeforePlaying();
		}

		public interface IAfterPlaying
		{
			void AfterPlaying();
		}

		public string description;

		public Target target;

		public bool playOnStart;

		public float delayStart;

		public float delayFinish;

		public float playSpeed;

		public UpdateType updateType;

		public bool ignoreTimeScale;

		public UnityEvent onFinish;

		private TweenController _explicitController;

		private List<Tuple<TweenController, int>> _implicitControllers;

		private byte _status;

		private Stats _stats;

		private UpdateType _currentUpdateType;

		private float _totalTime;

		public bool isPlayingBackwards => false;

		public float normalizedTweenTime => 0f;

		public Stats stats
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool Item
		{
			get
			{
				return false;
			}
			private set
			{
			}
		}

		public float totalTime
		{
			get
			{
				return 0f;
			}
			private set
			{
			}
		}

		internal float deltaTime => 0f;

		public float tweenTime { get; private set; }

		private TweenController controller => null;

		public virtual void Play()
		{
		}

		public void Pause()
		{
		}

		public void Resume()
		{
		}

		public void Rewind()
		{
		}

		public void Stop()
		{
		}

		public void Finish()
		{
		}

		protected virtual void OnFinishPlaying()
		{
		}

		protected abstract void Repaint();

		protected virtual void Start()
		{
		}

		protected virtual void OnDestroy()
		{
		}

		protected void OnEnable()
		{
		}

		private void OnUpdate()
		{
		}

		protected static bool AddController(Tween subject, TweenController controller, bool explicitControl)
		{
			return false;
		}

		protected static bool RemoveController(Tween subject, TweenController controller)
		{
			return false;
		}

		private void CheckControleeStatus(TweenController previous)
		{
		}

		private int ControllerProximity(TweenController value)
		{
			return 0;
		}
	}
}

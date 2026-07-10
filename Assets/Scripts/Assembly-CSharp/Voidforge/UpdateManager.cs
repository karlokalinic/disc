using System;
using System.Reflection;
using UnityEngine;

namespace Voidforge
{
	[Persistent]
	public class UpdateManager : SingletonComponent<UpdateManager>
	{
		public class UpdateAgent : Agent
		{
			protected Action UpdateAction;

			protected UpdateType _type;

			public UpdateAgent(Behaviour parent, Action Action, UpdateAttribute attribute)
				: base(null)
			{
			}

			public override void Dispose()
			{
			}
		}

		protected static float deltaGameTime;

		protected static float deltaRealTime;

		public static PrioritizedActionList normalEvent;

		public static PrioritizedActionList lateEvent;

		public static PrioritizedActionList fixedEvent;

		public static AgentCollection agents;

		[SerializeField]
		protected float gcCollectionInterval;

		protected float gcCollectionTimer;

		protected float normalRealTime;

		protected float lateRealTime;

		protected float fixedRealTime;

		public static float GetDeltaTime(bool realTime)
		{
			return 0f;
		}

		public static PrioritizedActionList Event(UpdateType type)
		{
			return null;
		}

		public static int RemoveAll(Action Callback)
		{
			return 0;
		}

		public static bool CreateAgent(Behaviour parent, MemberInfo memberInfo, UpdateAttribute attribute)
		{
			return false;
		}

		protected static bool Error(string message)
		{
			return false;
		}

		protected void Start()
		{
		}

		protected override void OnDestroy()
		{
		}

		protected void Update()
		{
		}

		protected void LateUpdate()
		{
		}

		protected void FixedUpdate()
		{
		}
	}
}

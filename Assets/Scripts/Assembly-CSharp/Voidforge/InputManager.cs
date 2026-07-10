using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

namespace Voidforge
{
	[Persistent]
	public class InputManager : SingletonComponent<InputManager>
	{
		public enum EVENT_PRIORITY
		{
			MINIMUM = 0,
			LOW = 1,
			MEDIUM = 10,
			HIGH = 100,
			MAXIMUM = int.MaxValue
		}

		public enum Condition
		{
			LeftMouse = 0,
			RightMouse = 1,
			MiddleMouse = 2,
			Alt = 3,
			Control = 4,
			Shift = 5,
			Windows = 6
		}

		public enum Trigger
		{
			Down = 0,
			Held = 1,
			Up = 2
		}

		public interface IKeyHandler
		{
			KeyCode[] InputKeys { get; }

			string name { get; }

			void OnInputKey();
		}

		public interface IPriority
		{
			int inputPriority { get; }
		}

		public class EventData
		{
			public bool used;
		}

		public class AxisEventData : EventData
		{
			public string axis;

			public float value;

			public AxisEventData(string axis, float value)
			{
			}
		}

		public abstract class TriggerEventData : EventData
		{
			public Trigger trigger;

			public int count;

			public TriggerEventData(Trigger trigger, int count)
			{
			}
		}

		public class ButtonEventData : TriggerEventData
		{
			public string button;

			public ButtonEventData(string button, Trigger trigger, int count)
				: base(default(Trigger), 0)
			{
			}
		}

		public class KeyCodeEventData : TriggerEventData
		{
			public KeyCode keyCode;

			public KeyCodeEventData(KeyCode keyCode, Trigger trigger, int count)
				: base(default(Trigger), 0)
			{
			}
		}

		public class ClickCounter
		{
			private int _counter;

			private float _timeStamp;

			private static float currentTime => 0f;

			public int value => 0;

			public int Increase()
			{
				return 0;
			}
		}

		public abstract class EventHandlerAgent : Agent
		{
			protected Action<EventData> Action;

			protected bool isActive => false;

			public EventHandlerAgent(Behaviour parent)
				: base(null)
			{
			}

			public override void Dispose()
			{
			}
		}

		public class EventDataAgent : EventHandlerAgent
		{
			public EventDataAgent(Behaviour parent, MethodInfo methodInfo, InputEventDataAttribute attribute)
				: base(null)
			{
			}
		}

		public class AxisAgent : EventHandlerAgent
		{
			private bool isZero;

			public AxisAgent(Behaviour parent, MethodInfo methodInfo, InputAxisAttribute attribute)
				: base(null)
			{
			}
		}

		public class ButtonAgent : EventHandlerAgent
		{
			public ButtonAgent(Behaviour parent, MethodInfo methodInfo, InputButtonAttribute attribute)
				: base(null)
			{
			}
		}

		public class KeyCodeAgent : EventHandlerAgent
		{
			public KeyCodeAgent(Behaviour parent, MethodInfo methodInfo, InputKeyAttribute attribute)
				: base(null)
			{
			}
		}

		public class KeyHandlerAgent : EventHandlerAgent
		{
			private bool CanHandle(KeyCodeEventData data, KeyCode inputKey)
			{
				return false;
			}

			public KeyHandlerAgent(IKeyHandler handler)
				: base(null)
			{
			}
		}

		public static PrioritizedList<ICursorSource> cursorSources;

		public static PrioritizedActionList<EventData> inputEvent;

		public static AgentCollection agents;

		public static HashSet<Tuple<string, bool>> observedAxes;

		public static Dictionary<string, ClickCounter> observedButtons;

		public static Dictionary<KeyCode, ClickCounter> observedKeyCodes;

		private LayerMask _layerMask;

		private NavAreaMask _navAreaMask;

		private CursorMode _cursorMode;

		private InputPointer _pointer;

		private Texture2D activeCursorTexture;

		private Vector2 activeCursorHotspot;

		private bool activeCursorCached;

		private bool _isLoading;

		public static LayerMask layerMask
		{
			get
			{
				return default(LayerMask);
			}
			set
			{
			}
		}

		public static int navAreaMask
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static InputPointer pointer => null;

		public bool IsLoading
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static bool IsCondition(Condition c)
		{
			return false;
		}

		public static bool IsSelected(Component component)
		{
			return false;
		}

		private void PlayNiceWithEventSystem(EventData data)
		{
		}

		private void SetCursor(ICursorSource cursor)
		{
		}

		public void Start()
		{
		}

		protected override void OnDestroy()
		{
		}

		private void Update()
		{
		}
	}
}

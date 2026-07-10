using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;

namespace InControl
{
	public abstract class PlayerActionSet
	{
		public BindingSourceType LastInputType;

		public ulong LastInputTypeChangedTick;

		public InputDeviceClass LastDeviceClass;

		public InputDeviceStyle LastDeviceStyle;

		private List<PlayerAction> actions;

		private List<PlayerOneAxisAction> oneAxisActions;

		private List<PlayerTwoAxisAction> twoAxisActions;

		private Dictionary<string, PlayerAction> actionsByName;

		private BindingListenOptions listenOptions;

		internal PlayerAction listenWithAction;

		private InputDevice activeDevice;

		private const ushort currentDataFormatVersion = 2;

		public InputDevice Device { get; set; }

		public List<InputDevice> IncludeDevices { get; private set; }

		public List<InputDevice> ExcludeDevices { get; private set; }

		public ReadOnlyCollection<PlayerAction> Actions { get; private set; }

		public ulong UpdateTick { get; protected set; }

		public bool Enabled { get; set; }

		public bool PreventInputWhileListeningForBinding { get; set; }

		public object UserData { get; set; }

		public PlayerAction Item => null;

		public bool IsListeningForBinding => false;

		public BindingListenOptions ListenOptions
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public InputDevice ActiveDevice => null;

		public event Action<BindingSourceType> OnLastInputTypeChanged
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

		public void Destroy()
		{
		}

		protected PlayerAction CreatePlayerAction(string name)
		{
			return null;
		}

		internal void AddPlayerAction(PlayerAction action)
		{
		}

		protected PlayerOneAxisAction CreateOneAxisPlayerAction(PlayerAction negativeAction, PlayerAction positiveAction)
		{
			return null;
		}

		protected PlayerTwoAxisAction CreateTwoAxisPlayerAction(PlayerAction negativeXAction, PlayerAction positiveXAction, PlayerAction negativeYAction, PlayerAction positiveYAction)
		{
			return null;
		}

		public PlayerAction GetPlayerActionByName(string actionName)
		{
			return null;
		}

		internal void Update(ulong updateTick, float deltaTime)
		{
		}

		public void Reset()
		{
		}

		private InputDevice FindActiveDevice()
		{
			return null;
		}

		public void ClearInputState()
		{
		}

		public bool HasBinding(BindingSource binding)
		{
			return false;
		}

		public void RemoveBinding(BindingSource binding)
		{
		}

		public byte[] SaveData()
		{
			return null;
		}

		public void LoadData(byte[] data)
		{
		}

		public string Save()
		{
			return null;
		}

		public void Load(string data)
		{
		}
	}
}

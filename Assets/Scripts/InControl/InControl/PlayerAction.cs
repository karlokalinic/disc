using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Runtime.CompilerServices;

namespace InControl
{
	public class PlayerAction : OneAxisInputControl
	{
		public BindingListenOptions ListenOptions;

		public BindingSourceType LastInputType;

		public ulong LastInputTypeChangedTick;

		public InputDeviceClass LastDeviceClass;

		public InputDeviceStyle LastDeviceStyle;

		private readonly List<BindingSource> defaultBindings;

		private readonly List<BindingSource> regularBindings;

		private readonly List<BindingSource> visibleBindings;

		private readonly ReadOnlyCollection<BindingSource> bindings;

		private readonly ReadOnlyCollection<BindingSource> unfilteredBindings;

		private readonly BindingSourceListener[] bindingSourceListeners;

		private bool triggerBindingEnded;

		private bool triggerBindingChanged;

		private InputDevice device;

		private InputDevice activeDevice;

		public string Name { get; private set; }

		public PlayerActionSet Owner { get; private set; }

		public object UserData { get; set; }

		public bool IsListeningForBinding => false;

		public ReadOnlyCollection<BindingSource> Bindings => null;

		public ReadOnlyCollection<BindingSource> UnfilteredBindings => null;

		internal InputDevice Device
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

		private bool LastInputTypeIsDevice => false;

		[Obsolete]
		public new float LowerDeadZone
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[Obsolete]
		public new float UpperDeadZone
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

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

		public event Action OnBindingsChanged
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

		public PlayerAction(string name, PlayerActionSet owner)
		{
		}

		public void AddDefaultBinding(BindingSource binding)
		{
		}

		public void AddDefaultBinding(params Key[] keys)
		{
		}

		public void AddDefaultBinding(KeyCombo keyCombo)
		{
		}

		public void AddDefaultBinding(Mouse control)
		{
		}

		public void AddDefaultBinding(InputControlType control)
		{
		}

		public bool AddBinding(BindingSource binding)
		{
			return false;
		}

		public bool InsertBindingAt(int index, BindingSource binding)
		{
			return false;
		}

		public bool ReplaceBinding(BindingSource findBinding, BindingSource withBinding)
		{
			return false;
		}

		public bool HasBinding(BindingSource binding)
		{
			return false;
		}

		public BindingSource FindBinding(BindingSource binding)
		{
			return null;
		}

		private void HardRemoveBinding(BindingSource binding)
		{
		}

		public void RemoveBinding(BindingSource binding)
		{
		}

		public void RemoveBindingAt(int index)
		{
		}

		private int CountBindingsOfType(BindingSourceType bindingSourceType)
		{
			return 0;
		}

		private void RemoveFirstBindingOfType(BindingSourceType bindingSourceType)
		{
		}

		private int IndexOfFirstInvalidBinding()
		{
			return 0;
		}

		public void ClearBindings()
		{
		}

		public void ResetBindings()
		{
		}

		public void ListenForBinding()
		{
		}

		public void ListenForBindingReplacing(BindingSource binding)
		{
		}

		public void StopListeningForBinding()
		{
		}

		private void RemoveOrphanedBindings()
		{
		}

		internal void Update(ulong updateTick, float deltaTime, InputDevice device)
		{
		}

		private void UpdateBindings(ulong updateTick, float deltaTime)
		{
		}

		private void DetectBindings()
		{
		}

		private void UpdateVisibleBindings()
		{
		}

		internal void Load(BinaryReader reader, ushort dataFormatVersion)
		{
		}

		internal void Save(BinaryWriter writer)
		{
		}
	}
}

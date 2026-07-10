using System;
using System.Runtime.CompilerServices;

namespace InControl
{
	public class PlayerOneAxisAction : OneAxisInputControl
	{
		private PlayerAction negativeAction;

		private PlayerAction positiveAction;

		public BindingSourceType LastInputType;

		public object UserData { get; set; }

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

		internal PlayerOneAxisAction(PlayerAction negativeAction, PlayerAction positiveAction)
		{
		}

		internal void Update(ulong updateTick, float deltaTime)
		{
		}

		private void ProcessActionUpdate(PlayerAction action)
		{
		}
	}
}

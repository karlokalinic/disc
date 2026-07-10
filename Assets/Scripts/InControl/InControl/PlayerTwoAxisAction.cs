using System;
using System.Runtime.CompilerServices;

namespace InControl
{
	public class PlayerTwoAxisAction : TwoAxisInputControl
	{
		private PlayerAction negativeXAction;

		private PlayerAction positiveXAction;

		private PlayerAction negativeYAction;

		private PlayerAction positiveYAction;

		public BindingSourceType LastInputType;

		public bool InvertXAxis { get; set; }

		public bool InvertYAxis { get; set; }

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

		internal PlayerTwoAxisAction(PlayerAction negativeXAction, PlayerAction positiveXAction, PlayerAction negativeYAction, PlayerAction positiveYAction)
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

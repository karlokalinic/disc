using UnityEngine;
using Voidforge;

namespace Sunshine.Feld
{
	public class FeldViewController : SingletonComponent<FeldViewController>
	{
		private Animator animator;

		private SuspendAnimator suspendAnimator;

		public FeldView currentView;

		private bool isInvisible;

		private bool _viewHudState;

		private bool _isHudSupressed;

		private static readonly int right1;

		private static readonly int left1;

		private static readonly int property;

		private static readonly int portraits1;

		private static readonly int hud1;

		private static readonly int dialog1;

		private static readonly int pause1;

		private static readonly int settings1;

		private static readonly int thc1;

		private static readonly int charsheet1;

		private static readonly int journal1;

		private static readonly int inventoryFx;

		private static readonly int helddocked1;

		public bool IsHudSupressed
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		protected override void Awake()
		{
		}

		private void ExecuteSuspendAnimator()
		{
		}

		public void ad()
		{
		}

		public void c()
		{
		}

		public void ai()
		{
		}

		public bool SetState(FeldView newFeldView)
		{
			return false;
		}

		private void ApplyAnimatorState()
		{
		}

		private void SetAnimatorBools(bool right, bool left, bool leftThin, bool portraits, bool hud, bool dialog, bool pause, bool settings, bool thc, bool charsheet, bool journal, bool inventoryFX, bool helddocked)
		{
		}

		private void AlphaTo(float to, float time)
		{
		}
	}
}

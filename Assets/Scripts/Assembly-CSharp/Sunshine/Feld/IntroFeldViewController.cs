using UnityEngine;
using Voidforge;

namespace Sunshine.Feld
{
	public class IntroFeldViewController : SingletonComponent<IntroFeldViewController>
	{
		private Animator animator;

		private SuspendAnimator suspendAnimator;

		public FeldView currentView;

		private bool _viewHudState;

		private bool _isHudSupressed;

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

		public void NextState()
		{
		}

		public void PrevState()
		{
		}

		public void SetState(int to)
		{
		}

		public void SetArch(int to)
		{
		}

		public void SetCharsheet(bool to)
		{
		}

		private void AlphaTo(float to, float time)
		{
		}

		public static void Init()
		{
		}

		public static void ArchetypeSelection()
		{
		}

		public static void PreStats()
		{
		}

		public static void PostStats()
		{
		}

		public static void SetSkill()
		{
		}

		public static void QuitSequence()
		{
		}
	}
}

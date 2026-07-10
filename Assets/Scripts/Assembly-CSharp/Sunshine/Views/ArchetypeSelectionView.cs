using System.Collections;
using Sunshine.Feld;
using UnityEngine;

namespace Sunshine.Views
{
	public class ArchetypeSelectionView : View
	{
		private static bool canPlaySounds;

		private Coroutine canPlaySoundsCor;

		[SerializeField]
		private GameObject hardcoreIcon;

		public static bool CanPlaySounds => false;

		public override ViewType GetViewType()
		{
			return default(ViewType);
		}

		public override FeldView GetFeldViewType()
		{
			return default(FeldView);
		}

		public override void InitTransforms()
		{
		}

		public override bool CanTransitionFromCurrentView()
		{
			return false;
		}

		public override void SwitchToView(ViewType previousView)
		{
		}

		public override void OnExitView(ViewType nextView)
		{
		}

		public override void SetInitialSelect()
		{
		}

		public IEnumerator StopSoundsCoroutine()
		{
			return null;
		}

		protected override void OnFrameAfterSwitchedToCompleated()
		{
		}
	}
}

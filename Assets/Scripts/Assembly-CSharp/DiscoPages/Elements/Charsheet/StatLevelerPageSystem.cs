using DG.Tweening;
using DiscoPages.Elements.Common;
using Sunshine.Metric;
using UnityEngine;
using UnityEngine.UI;

namespace DiscoPages.Elements.Charsheet
{
	public class StatLevelerPageSystem : StatLeveler
	{
		private const float GO_BACK_DURATION = 0.33f;

		private float TAPE_MOVE_DURATION;

		private const float PROGRESS_TO_ACCEPT_SWIPE = 0.28f;

		private const float SPEED_CONDITION_VALUE = 7f;

		[SerializeField]
		private Image backgroundImg;

		[SerializeField]
		private SwipeDetector swipeDetector;

		private Sequence statChangeSequence;

		private Sequence swipeLeftSequence;

		private Sequence swipeRightSequence;

		private Sequence goBackSequence;

		private bool waitForSequenceToEnd;

		private bool swipeStarted;

		private Modifier rankModifier;

		private Ability abilityRef;

		private CharacterSheet character;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public override void UpdateData(bool showUp, bool showDown)
		{
		}

		public override void UpgradeRank()
		{
		}

		public override void DowngradeRank()
		{
		}

		private bool CanUpgradeAbility(int num)
		{
			return false;
		}

		private bool CanDowngradeAbility(int num)
		{
			return false;
		}

		private void AnimateToValue(int statValue)
		{
		}

		private void OnSwipeStarted(SwipeDetector.SwipeData data)
		{
		}

		private void OnSwipe(SwipeDetector.SwipeData data)
		{
		}

		private void OnSwipeEnded(SwipeDetector.SwipeData data)
		{
		}

		private void PrepareAnimationSequences(int statValue)
		{
		}
	}
}

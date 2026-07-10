using Conditions;
using UnityEngine;

namespace CollageMode
{
	public class UnlockHiddenImage : BaseCondition
	{
		[SerializeField]
		private HiddenImage hiddenImage;

		[SerializeField]
		private ZoomToAlphaChanger zoomToAlphaChanger;

		[SerializeField]
		private DistanceUnlocker distanceChecker;

		[SerializeField]
		private float minimumUnlockAlfaValue;

		[SerializeField]
		private float maximumUnlockAlfaValue;

		public bool IsUnlocked { get; private set; }

		public override bool CheckCondition()
		{
			return false;
		}

		private void Reset()
		{
		}

		private void Awake()
		{
		}

		private void Update()
		{
		}

		public void GetUnlockState()
		{
		}

		private bool UnlockConditions()
		{
			return false;
		}

		private void CheckIfShouldUnlock()
		{
		}

		private void SaveUnlockState()
		{
		}

		private void SaveLockedState()
		{
		}

		private void ShowUnlockAnimation()
		{
		}
	}
}

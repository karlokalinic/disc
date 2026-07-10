namespace Sunshine
{
	public class PositionStateSwitcher : StateSwitcher
	{
		private Location location;

		private bool autoDisabled;

		private bool isInitialized;

		protected override void OnStartInitialized()
		{
		}

		protected override void OnSceneActivated()
		{
		}

		protected override void OnSceneDeactivated()
		{
		}

		public override void BecomeActive()
		{
		}

		public override void StopBeingActive()
		{
		}

		private StateTransformPair GetPair(string stateName)
		{
			return null;
		}

		public void OnValidate()
		{
		}

		private void CheckAndPrepare()
		{
		}
	}
}

using System.Collections;

namespace Sunshine
{
	public class CorpseDream : CutsceneSituation
	{
		private static bool isSequenceInProgress;

		public static bool IsSequenceInProgress => false;

		public override IEnumerator PerformActions()
		{
			return null;
		}

		private void FadeBackAfterTransition()
		{
		}
	}
}

using System.Collections;
using Voidforge;

namespace Sunshine
{
	public class LedgerDream : CutsceneSituation
	{
		private static bool isSequenceInProgress;

		private static Timer timer;

		public static bool AfterLedgerDialogueInProgress;

		public static bool IsSequenceInProgress => false;

		public override IEnumerator PerformActions()
		{
			return null;
		}
	}
}

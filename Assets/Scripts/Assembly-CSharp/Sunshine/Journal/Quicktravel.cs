using System.Collections;

namespace Sunshine.Journal
{
	public class Quicktravel : CutsceneSituation
	{
		public static string AreaToTeleport;

		public static string LocationMarker;

		public static string CameraFocusPoint;

		private static bool isSequenceInProgress;

		public static bool IsSequenceInProgress => false;

		public override IEnumerator PerformActions()
		{
			return null;
		}

		public static void FocusCamera(string cameraFocusPoint)
		{
		}
	}
}

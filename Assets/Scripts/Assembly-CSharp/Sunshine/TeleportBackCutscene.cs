using System.Collections;

namespace Sunshine
{
	public class TeleportBackCutscene : CutsceneSituation
	{
		private static string SavedArea;

		public static string CameraFocusPoint;

		private static bool isSequenceInProgress;

		public static bool IsSaved;

		public static CameraMarker savedCameraMarker;

		public static FormationMarker savedFormationMarker;

		public static bool IsSequenceInProgress => false;

		public static void SaveArea()
		{
		}

		private static void CreateSavedCameraMarker()
		{
		}

		private static void CreateSavedFormationMarker()
		{
		}

		public static void ResetStates()
		{
		}

		public override IEnumerator PerformActions()
		{
			return null;
		}

		private void FadeBackAfterTransition()
		{
		}
	}
}

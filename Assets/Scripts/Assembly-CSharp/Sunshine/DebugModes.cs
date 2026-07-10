using Voidforge;

namespace Sunshine
{
	public class DebugModes : SingletonComponent<DebugModes>
	{
		public bool demoModeAlwaysUnlocked;

		public bool conventionModeAlwaysUnlocked;

		public static bool demoModeFromEditor;

		public static bool steamIntegrationFromEditor;

		public static DebugMode CurrentMode { get; private set; }

		public static bool IsDebugMode => false;

		public static bool ShortcutsActive => false;

		public static bool PlaceholdersActive => false;

		public static bool ParseCommandLine(string arg)
		{
			return false;
		}

		public static string GetCommandLineArgument(string arg)
		{
			return null;
		}

		protected override void Awake()
		{
		}

		private bool IsConsoleBuild()
		{
			return false;
		}

		public void SetDeveloperMode()
		{
		}

		public void UnsetDeveloperMode()
		{
		}

		public void DumpModeName()
		{
		}
	}
}

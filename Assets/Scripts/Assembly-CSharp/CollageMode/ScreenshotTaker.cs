using UnityEngine;

namespace CollageMode
{
	public class ScreenshotTaker : MonoBehaviour
	{
		private const string _SCREENSHOT_PATH_PLAYER_PREFS_KEY = "ScreenshotPath";

		private string screenshotPath;

		private string lastScreenshotFileName;

		private string DefaultScreenshotPath => null;

		private string ScreenshotFileName => null;

		private void Start()
		{
		}

		public void TakeScreenshot()
		{
		}

		public void TakeScreenshot(string path, string fileName)
		{
		}

		private string FixPath(string path, string fileName)
		{
			return null;
		}

		private void OnScreenshotPathChangeRequested(string newScreenshotPath)
		{
		}

		private void SetDefaultScreenshotPath()
		{
		}
	}
}

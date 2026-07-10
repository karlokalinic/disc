using System;

namespace CollageMode
{
	[Flags]
	public enum CollageInputType
	{
		Default = 1,
		ElementSelectedDrawer = 2,
		AssetDrawer = 4,
		DialogueEditor = 8,
		TakingScreenshot = 0x10,
		Popup = 0x20,
		ScreenshotPopup = 0x40,
		Locked = int.MinValue
	}
}

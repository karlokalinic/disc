using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace CollageMode
{
	public class CaptureButton : LiteSingleton<CaptureButton>
	{
		[SerializeField]
		private HiddenImageAssembler hiddenImageAssembler;

		[SerializeField]
		private ScreenshotTaker screenshotTaker;

		[Space]
		[SerializeField]
		private Button screenshotButton;

		public bool IsTakingScreenshot { get; private set; }

		public event Action OnBeforeScreenshot
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action OnAfterScreenshot
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		private void Start()
		{
		}

		public void ToggleUIAndTakeScreenshot()
		{
		}

		public void TakeScreenshotForSave(Action<Texture2D> callback)
		{
		}

		private Texture2D CaptureScreenshootPS4(Camera cam, int width, int height)
		{
			return null;
		}

		private Texture2D CaptureScreenshot()
		{
			return null;
		}

		public void CompleteCapture()
		{
		}
	}
}

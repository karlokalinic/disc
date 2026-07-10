using System;
using System.Collections;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace CollageMode
{
	public class ScreenshotPopup : MonoBehaviour
	{
		private const string savedToFormatTerm = "BUTTON/SAVED_PATH_FORMAT";

		[SerializeField]
		private TextMeshProUGUI text;

		[SerializeField]
		private Button openButton;

		[SerializeField]
		private Button changeButton;

		[SerializeField]
		private Button closeButton;

		[SerializeField]
		private CanvasGroup canvasGroup;

		[SerializeField]
		private Image flashImage;

		[SerializeField]
		private float flashFadeTime;

		[SerializeField]
		private float fadeTime;

		[SerializeField]
		private float showTime;

		private string screenshotPath;

		public bool IsOpen => false;

		public event Action<string> OnScreenshotPathChangeRequested
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

		private void Awake()
		{
		}

		private void Update()
		{
		}

		public void Show(string screenshotPath)
		{
		}

		public void Hide()
		{
		}

		private IEnumerator HideAfterTimeCoroutine()
		{
			return null;
		}

		private void SetScreenshotPath(string screenshotPath)
		{
		}

		private void OnOpenButtonClicked()
		{
		}

		private void OnChangeButtonClicked()
		{
		}

		private void OnCloseButtonClicked()
		{
		}
	}
}

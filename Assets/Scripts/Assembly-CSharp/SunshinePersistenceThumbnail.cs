using System;
using System.Collections;
using Sunshine.Views;
using UnityEngine;

public static class SunshinePersistenceThumbnail
{
	private const int THUMBNAIL_QUALITY = 90;

	private const int THUMBNAIL_WIDTH = 512;

	private const int THUMBNAIL_HEIGHT = 288;

	private const int THUMBNAIL_WIDESCREEN_HEIGHT = 214;

	private const int THUMBNAIL_1610_HEIGHT = 320;

	public static Action<string, byte[]> ThumbnailQueryCB;

	public static IEnumerator ThumbnailCoroutine;

	public static string ThumbnailInProgress;

	public static string ThumbnailWaiting;

	public static Texture2D ScreenshotTexture { get; private set; }

	private static int ThumbnailHeight => 0;

	public static void AddThumbnailToQueue(string saveName)
	{
	}

	public static IEnumerator RunThumbnailer()
	{
		return null;
	}

	public static void StartProcess(SaveLoadController controller)
	{
	}

	public static void StopProcess(SaveLoadController controller)
	{
	}

	public static IEnumerator LoadThumbnail(string saveName, Action<byte[]> callback)
	{
		return null;
	}

	public static void Release()
	{
	}

	public static void CaptureAndResizeScreenshot()
	{
	}

	public static Texture2D CaptureScreenshotFromCamera(Camera cam, int width, int height)
	{
		return null;
	}

	public static Texture2D GetScreenshotTexture(string fileNamePrefix, bool isBundled, bool isDeletable)
	{
		return null;
	}

	public static Texture2D GetScreenshotTextureFromMemory(byte[] bytes)
	{
		return null;
	}

	public static byte[] GetScreenshotTextureBytes()
	{
		return null;
	}
}

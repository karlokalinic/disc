using System;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.UI;

public class AsyncImageLoader : MonoBehaviour
{
	[SerializeField]
	private Image image;

	private Action onImageLoaded;

	private AsyncOperationHandle<Sprite> spriteHandle;

	private bool isAsyncPrepared;

	private string prevPath;

	private void OnDestroy()
	{
	}

	public void LoadImageAsync(string addressablePath, Action onImageLoaded)
	{
	}

	private void SetImage(AsyncOperationHandle<Sprite> spriteHandle)
	{
	}

	public void UnloadImageAsync()
	{
	}
}

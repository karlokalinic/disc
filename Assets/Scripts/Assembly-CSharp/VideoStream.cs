using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine.Video;

public class VideoStream : MonoBehaviour
{
	[SerializeField]
	private VideoPlayer videoPlayer;

	[SerializeField]
	private RawImage rawImage;

	[SerializeField]
	private UnityEvent onVideoPrepared;

	private void Awake()
	{
	}

	public Coroutine StartVideo()
	{
		return null;
	}

	public bool CheckifIsPlaying()
	{
		return false;
	}

	private IEnumerator StreamVideo()
	{
		return null;
	}
}

using System;
using System.Collections;
using UnityEngine;
using Voidforge;

public class ZaumLogoScript : MonoBehaviour
{
	public static ZaumLogoScript zaumLogoScript;

	public GameObject disableMeOnAnyKey;

	public VideoStream videoStream;

	private bool skippable;

	public static Action OnZaumLogoFinishedEvent;

	public static LobbyFade DeferredDestroyLobbyFade;

	private void Awake()
	{
	}

	private void OnDisable()
	{
	}

	private IEnumerator StartVideo()
	{
		return null;
	}

	private void Close()
	{
	}

	private void regainControl()
	{
	}

	private void Update()
	{
	}

	public void Play()
	{
	}

	private void OnVideoFinished()
	{
	}

	private void LockInput()
	{
	}

	private void UnlockInput()
	{
	}

	private void ConsumeAllInputEvents(InputManager.EventData data)
	{
	}

	private void DestroyLobbyFade()
	{
	}
}

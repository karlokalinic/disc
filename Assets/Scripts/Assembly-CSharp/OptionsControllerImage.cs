using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsControllerImage : MonoBehaviour
{
	public GameObject disclaimerText;

	public Image controlsBackground;

	public GameObject controllerSubview;

	private Image[] imgs;

	private static Dictionary<string, Sprite> loadedImages;

	private InputHotplugHandler.InputDeviceType currentDeviceType;

	private static bool Active;

	private void OnLanguageChanged()
	{
	}

	private IEnumerator RefreshAllTextFieldsAfterLanguageChange()
	{
		return null;
	}

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}

	public static void Enter()
	{
	}

	public static void Exit()
	{
	}

	public static void ReleaseImages()
	{
	}

	private void OnDeviceChanged(string _nameDevice, InputHotplugHandler.InputDeviceType deviceType)
	{
	}

	private void ChangeKeyboardImage()
	{
	}

	private void ChangeControllerImage(InputHotplugHandler.InputDeviceType type)
	{
	}

	private void LoadControlsImages(string folderPath)
	{
	}

	private Sprite LoadSprite(string filename)
	{
		return null;
	}
}

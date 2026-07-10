using UnityEngine;
using UnityEngine.UI;

public class ControllerInputImage : MonoBehaviour
{
	private InputHotplugHandler.InputDeviceType currentDeviceType;

	private Image image;

	private Sprite currentSprite;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnDeviceChanged(string name, InputHotplugHandler.InputDeviceType deviceType)
	{
	}

	private void LoadControllerImage(InputHotplugHandler.InputDeviceType deviceType)
	{
	}

	private void LoadControllerImages(string folderPath)
	{
	}
}

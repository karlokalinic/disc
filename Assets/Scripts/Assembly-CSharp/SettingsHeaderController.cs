using InControl;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SettingsHeaderController : MonoBehaviour
{
	public Image settingsTabHighlight;

	public GameObject settingsButton;

	public GameObject controlsButton;

	public TextMeshProUGUI settingsText;

	public TextMeshProUGUI controlsText;

	public GameObject settingsView;

	public GameObject controlsView;

	public GameObject controllerControlsSubview;

	public GameObject keyboardControlsSubview;

	public Color active;

	public Color inactive;

	public PlayerAction settingsAction;

	public PlayerAction controlsAction;

	private InputHotplugHandler.InputDeviceType currentDeviceType;

	public static SettingsHeaderController singleton;

	public void SelectSettingsView()
	{
	}

	public void SelectControlsView()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	public static void SetKeyboardView(bool to)
	{
	}

	public static void ShowNone()
	{
	}

	private void OnDeviceChanged(string name, InputHotplugHandler.InputDeviceType deviceType)
	{
	}
}

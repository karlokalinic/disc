using UnityEngine;

public class PauseHelp : LiteSingleton<PauseHelp>
{
	public GameObject tipsPanel;

	public GameObject iconToggle;

	public GameObject controllerPanel;

	public GameObject keyboardPanel;

	[SerializeField]
	private Vector3 initPos;

	[SerializeField]
	private Vector3 tipsPanelInitPos;

	private RectTransform rectTransform;

	private RectTransform tipsRectTransform;

	private InputHotplugHandler.InputDeviceType currentDeviceType;

	public bool visible;

	public bool visibleInPause;

	public bool ignoreOnce;

	protected override void Awake()
	{
	}

	private void Start()
	{
	}

	public void ShowIfActive()
	{
	}

	public void Show()
	{
	}

	public void Hide()
	{
	}

	public void Toggle()
	{
	}

	private void OnDeviceChanged(string name, InputHotplugHandler.InputDeviceType deviceType)
	{
	}

	public static void SetKeyboardView(bool to)
	{
	}
}

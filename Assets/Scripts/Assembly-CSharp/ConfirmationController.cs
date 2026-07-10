using System;
using System.Collections;
using UnityEngine.UI;

public class ConfirmationController : LiteSingleton<ConfirmationController>
{
	public Text Text;

	public Button Confirm;

	public Button Cancel;

	public float currCountdownValue;

	private string textToApply;

	private bool isCounting;

	private bool confirmationShowedAtleastOnce;

	private float timeConfirmWasOpened;

	private string localizationTerm;

	private bool isLocalized;

	private bool isFormatted;

	public bool IsVisible => false;

	public void Start()
	{
	}

	private void Update()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnLanguageChanged()
	{
	}

	public void ShowConfirmation(string text, Action onConfirm, Action onCancel, bool showCancel = true, string soundVariationName = "small-switch-full", string soundGroup = "gamestart")
	{
	}

	public void ShowLocalizedConfirmation(string localizationTerm, Action onConfirm, Action onCancel, bool showCancel = true, string soundVariationName = "small-switch-full", string soundGroup = "gamestart")
	{
	}

	public void ShowLocalizedConfirmationWithFormat(string localizationFormatTerm, string textToApply, Action onConfirm, Action onCancel, bool showCancel = true, string soundVariationName = "small-switch-full", string soundGroup = "gamestart")
	{
	}

	public IEnumerator StartCountdown(float countdownValue = 10f, Action onCancel = null)
	{
		return null;
	}

	public void ShowConfirmationTimer(string localizationTerm, Action onConfirm, Action onCancel, bool showCancel = true, float time = 0f)
	{
	}

	private void SetButtonActions(Button button, Action action)
	{
	}

	private void RegisterEscapeKeyListener()
	{
	}

	private void UnregisterEscapeKeyListener()
	{
	}

	private void CloseOnEscapeKey()
	{
	}

	private void IgnoreTabInputs()
	{
	}

	public void OnCloseConfirmation(bool force)
	{
	}

	private void RefreshViewSelect()
	{
	}

	public static void ShowErrorMessage(string errorTitle, Action onConfirmPressed = null, Action OnCancelPressed = null)
	{
	}

	public static void ShowErrorMessage(string errorTitle, Exception exceptionMessage, Action onConfirmPressed = null, Action OnCancelPressed = null)
	{
	}
}

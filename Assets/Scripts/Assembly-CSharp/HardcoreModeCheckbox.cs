using Sunshine.Views;
using UnityEngine;
using UnityEngine.UI;

public class HardcoreModeCheckbox : LiteSingleton<HardcoreModeCheckbox>
{
	[SerializeField]
	private Toggle checkbox;

	private bool valueBeforePreview;

	private GameModeController.GameMode gameModeOnEnterView;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	public void OnValueChanged(bool value)
	{
	}

	private void ShowTurnOnConfirmation()
	{
	}

	private void ShowTurnOffConfirmation()
	{
	}

	private void ChangeHardcoreModeToOff()
	{
	}

	private void DisableHardcoreMode()
	{
	}

	public void ChangeGameMode(bool value)
	{
	}

	private void OnChangeView(ViewType viewType)
	{
	}

	private bool CanChangeGameMode()
	{
		return false;
	}

	public void PreviewReset()
	{
	}

	public void CancelPreview()
	{
	}

	public void ResetSettings()
	{
	}
}

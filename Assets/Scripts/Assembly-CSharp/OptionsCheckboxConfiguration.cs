using UnityEngine;
using UnityEngine.UI;

public abstract class OptionsCheckboxConfiguration<T> : LiteSingleton<T> where T : MonoBehaviour
{
	[SerializeField]
	private Toggle toggle;

	private bool valueBeforePreview;

	private bool wasInitialized;

	private bool value;

	public bool Value
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	protected abstract string SettingName { get; }

	protected abstract bool DefaultValue { get; }

	protected override void Awake()
	{
	}

	public void OnEnable()
	{
	}

	private void OnDestroy()
	{
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

	public virtual void OnValueChanged(bool value)
	{
	}
}

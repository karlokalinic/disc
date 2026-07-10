using DarkTonic.MasterAudio;
using UnityEngine;
using UnityEngine.UI;

public class AudioConfigurationSliders : LiteSingleton<AudioConfigurationSliders>
{
	[SerializeField]
	private Slider spatialsourceSlider;

	[SerializeField]
	private Slider uiSlider;

	[SerializeField]
	private Slider musicSlider;

	[SerializeField]
	private Slider voiceoverSlider;

	[SerializeField]
	private Slider weatherSlider;

	private bool valuesSet;

	private float[] slidersValuesBeforePreview;

	private PlaylistController PLC;

	protected override void Awake()
	{
	}

	public void Start()
	{
	}

	public void ResetSliders(bool value = false)
	{
	}

	public void PreviewReset()
	{
	}

	public void CancelPreview()
	{
	}

	private void OnDestroy()
	{
	}

	public void SetVolumes(bool useMenuVolumes = true)
	{
	}

	private void OnAnySliderValueChanged(float newValue)
	{
	}

	public void ReApply()
	{
	}
}

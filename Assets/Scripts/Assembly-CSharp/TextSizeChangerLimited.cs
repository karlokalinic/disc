using LocalizationCustomSystem;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TextSizeChangerLimited : MonoBehaviour
{
	[SerializeField]
	private bool keepMediumAndSmallTheSame;

	private Text text;

	private TextMeshProUGUI textMeshProUGUI;

	private float defaultFontSize;

	private float defaultMinFontSize;

	private float defaultMaxFontSize;

	private LocalizeFontSize localizeFontSize;

	private LocalizeFontBestFit localizeFontBestFit;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public void OnTextSizeChanged(TextSizeConfiguration.TextSize textSize)
	{
	}
}

using TMPro;
using UnityEngine;

public class ThoughtTextSizeChanger : MonoBehaviour
{
	[SerializeField]
	private bool keepMediumAndSmallTheSame;

	private TextMeshProUGUI textMeshProUGUI;

	private float defaultMaxFontSize;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDestroy()
	{
	}

	public void OnTextSizeChanged(TextSizeConfiguration.TextSize textSize)
	{
	}
}

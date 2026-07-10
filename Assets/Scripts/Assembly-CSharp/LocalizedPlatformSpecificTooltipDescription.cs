using LocalizationCustomSystem;
using UnityEngine;

public class LocalizedPlatformSpecificTooltipDescription : MonoBehaviour, IGenericTooltipDataProvider
{
	[SerializeField]
	private TranslationString NumericInfo;

	[SerializeField]
	private TranslationString SwitchTitle;

	[SerializeField]
	private TranslationString SwitchDescription;

	[SerializeField]
	private TranslationString XboxTitle;

	[SerializeField]
	private TranslationString XboxDescription;

	[SerializeField]
	private TranslationString PlayStationTitle;

	[SerializeField]
	private TranslationString PlayStationDescription;

	[SerializeField]
	private TranslationString PCTitle;

	[SerializeField]
	private TranslationString PCDescription;

	public GenericTooltipData GetTooltipData()
	{
		return null;
	}
}

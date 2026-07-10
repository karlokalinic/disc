using LocalizationCustomSystem;
using UnityEngine;

public class LocalizedTooltipDescription : MonoBehaviour, IGenericTooltipDataProvider
{
	[SerializeField]
	private TranslationString title;

	[SerializeField]
	private TranslationString NumericInfo;

	[SerializeField]
	private TranslationString Description;

	public GenericTooltipData GetTooltipData()
	{
		return null;
	}

	public void SetTooltip(string titleTerm, string descriptionTerm, string numericInfoTerm)
	{
	}
}

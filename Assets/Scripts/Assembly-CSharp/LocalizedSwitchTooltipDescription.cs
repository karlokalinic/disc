using LocalizationCustomSystem;
using UnityEngine;

public class LocalizedSwitchTooltipDescription : LocalizedTooltipDescription
{
	[SerializeField]
	private TranslationString SwitchAdditionFormat;

	[SerializeField]
	private TranslationString handheldTerm;

	[SerializeField]
	private TranslationString TVTerm;

	public new GenericTooltipData GetTooltipData()
	{
		return null;
	}
}

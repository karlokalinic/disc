using UnityEngine;

public class HudPortraitBuff : MonoBehaviour, IGenericTooltipDataProvider
{
	public string SubstanceName;

	public GenericTooltipData GetTooltipData()
	{
		return null;
	}
}

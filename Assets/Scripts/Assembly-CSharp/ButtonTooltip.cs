using UnityEngine;

public class ButtonTooltip : MonoBehaviour, IGenericTooltipDataProvider
{
	public string Title;

	public string Description;

	public string NumericInfo;

	public GenericTooltipData GetTooltipData()
	{
		return null;
	}

	public void SetTooltip(string title, string description, string numericInfo)
	{
	}
}

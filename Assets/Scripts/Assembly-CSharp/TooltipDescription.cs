using UnityEngine;

public class TooltipDescription : MonoBehaviour, IGenericTooltipDataProvider
{
	[SerializeField]
	private string title;

	[SerializeField]
	private string NumericInfo;

	[SerializeField]
	private string Description;

	public GenericTooltipData GetTooltipData()
	{
		return null;
	}
}

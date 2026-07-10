using UnityEngine;

public class ConditionalSenseOrb : SenseOrb
{
	[TextArea]
	[SerializeField]
	private string additionalConditions;

	public override bool PrerequisitesMet()
	{
		return false;
	}
}

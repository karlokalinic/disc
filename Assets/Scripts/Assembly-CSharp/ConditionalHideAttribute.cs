using UnityEngine;

public class ConditionalHideAttribute : PropertyAttribute
{
	public string ConditionalSourceField;

	public string ConditionalSourceField2;

	public bool HideInInspector;

	public bool Inverse;

	public ConditionalHideAttribute(string conditionalSourceField)
	{
	}

	public ConditionalHideAttribute(string conditionalSourceField, bool hideInInspector)
	{
	}

	public ConditionalHideAttribute(string conditionalSourceField, bool hideInInspector, bool inverse)
	{
	}

	public ConditionalHideAttribute(bool hideInInspector = false)
	{
	}
}

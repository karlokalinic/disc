using Sunshine.Metric;
using UnityEngine;

public class StatBlock : MonoBehaviour
{
	public Color color;

	public AbilityType type;

	public virtual Color UpdateColor()
	{
		return default(Color);
	}

	public void SetCharacter()
	{
	}

	public void RefreshData()
	{
	}

	public void Generate()
	{
	}
}

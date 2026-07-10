using I2.Loc;
using UnityEngine;

public class LocalizedLayerElement : LayerElement
{
	[HideInInspector]
	public Localize localization;

	protected override void Start()
	{
	}

	public override void SetParameters(Sprite sprite, AnimationCurve appearCurve, AnimationCurve disappearCurve, float flashTime, Material material)
	{
	}

	public void SetLocalizedParameters(Sprite fallbackSprite, string imageLocalizationTerm, AnimationCurve appearCurve, AnimationCurve disappearCurve, float flashTime, Material material)
	{
	}
}

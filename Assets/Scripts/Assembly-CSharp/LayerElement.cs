using System.Collections.Generic;
using UnityEngine;
using Voidforge;

public class LayerElement : MonoBehaviour
{
	public static LayerElement lastLayer;

	public static List<LayerElement> layers;

	[HideInInspector]
	public TweenAlpha tween;

	[HideInInspector]
	public SpriteRenderer spriteRenderer;

	protected AnimationCurve appear;

	protected AnimationCurve disappear;

	protected virtual void OnEnable()
	{
	}

	protected virtual void OnDisable()
	{
	}

	protected virtual void Start()
	{
	}

	public virtual void SetParameters(Sprite sprite, AnimationCurve appearCurve, AnimationCurve disappearCurve, float flashTime, Material material)
	{
	}

	protected void AddToLayer()
	{
	}

	protected void RemoveFromLayer()
	{
	}

	public void SetCustomDisappearCurve(AnimationCurve disappearCurve)
	{
	}

	public void Show()
	{
	}

	public void Hide()
	{
	}

	public void HideTail()
	{
	}
}

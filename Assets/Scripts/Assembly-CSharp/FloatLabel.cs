using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using Voidforge;

public class FloatLabel : VoidElement
{
	[SerializeField]
	protected float startingAlpha;

	protected ComponentRef<TweenAlpha> alpha;

	[GetComponent]
	protected ComponentRef<Renderer> _renderers;

	[GetComponent]
	protected ComponentRef<Graphic> _graphics;

	public float AppearTime
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public void WaitAndFadeout(UnityAction callback)
	{
	}

	protected Color SetAlpha(Color color, float alpha)
	{
		return default(Color);
	}

	protected void Start()
	{
	}
}

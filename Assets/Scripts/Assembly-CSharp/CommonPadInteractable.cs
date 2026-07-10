using System;
using FortressOccident;
using UnityEngine;

[Serializable]
public class CommonPadInteractable
{
	private InteractableType m_type;

	private OrbUiElement m_orb;

	private MouseOverHighlight m_interactable;

	private float m_sortFactor;

	public OrbUiElement Orb => null;

	public MouseOverHighlight Interactable => null;

	public float SortFactor => 0f;

	public CommonPadInteractable()
	{
	}

	public CommonPadInteractable(OrbUiElement orb, float distance)
	{
	}

	public CommonPadInteractable(MouseOverHighlight interactable, float distance)
	{
	}

	public void Setup(OrbUiElement orb, float sortFactor)
	{
	}

	public void Setup(MouseOverHighlight interactable, float sortFactor)
	{
	}

	public void Select(bool value)
	{
	}

	public void Interact(bool doubletap = false)
	{
	}

	public void Destroy()
	{
	}

	public override string ToString()
	{
		return null;
	}

	public InteractableType CurrentType()
	{
		return default(InteractableType);
	}

	public bool IsTheSame(CommonPadInteractable objB)
	{
		return false;
	}

	public Vector3 GetWorldPosition()
	{
		return default(Vector3);
	}

	public bool HaveAnyWorldInteractableObject()
	{
		return false;
	}

	public bool CanInteract()
	{
		return false;
	}

	public Vector2 GetUIPositionToShow()
	{
		return default(Vector2);
	}

	public GameEntity GetGameEntity()
	{
		return null;
	}

	public bool PathToInteractableExist()
	{
		return false;
	}

	public int GetInstanceID()
	{
		return 0;
	}

	public Transform GetTransform()
	{
		return null;
	}
}

using System;
using System.Collections.Generic;
using FortressOccident;
using UnityEngine;

[Serializable]
public class InteractableAutoHighlightManager
{
	private CharacterAnalogueControl m_analogueControl;

	private HashSet<CommonPadInteractable> m_availableHighlightables;

	private List<CommonPadInteractable> m_toRemove;

	private Queue<CommonPadInteractable> interactableQueue;

	private float m_timeSinceHighlightUpdate;

	private bool m_isActive;

	private bool m_isEnabled;

	public bool IsEnabled
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public void SetAutoHighlightActive(bool value)
	{
	}

	public InteractableAutoHighlightManager(CharacterAnalogueControl analogueControl)
	{
	}

	public void Add(CommonPadInteractable interactable)
	{
	}

	public void Remove(CommonPadInteractable interactable)
	{
	}

	public void Destroy()
	{
	}

	public void OnUpdate()
	{
	}

	private void UpdateHighlightableInTequillaRange()
	{
	}

	private bool CheckHighlightableInTequillaRange(MouseOverHighlight mouseOverHighlight, Vector2 screenTequillaPosition, float interactionRange, bool highlight = true)
	{
		return false;
	}

	private bool IntersectionPointCircles(Vector2 P0, float radius0, Vector2 P1, float radius1)
	{
		return false;
	}

	private bool IntersectionPointV2(Vector2 P0, Vector2 P1, Vector2 center, float radius)
	{
		return false;
	}

	public void OnDrawGUI()
	{
	}

	private void VisualiseInteractionCircle(float interactableMaxDistance)
	{
	}

	private void VisualiseDistances()
	{
	}

	private void DrawLineToHighlightable(MouseOverHighlight highlightable, Vector2 screenTequillaPosition)
	{
	}

	public void ClearAutoHighlight()
	{
	}
}

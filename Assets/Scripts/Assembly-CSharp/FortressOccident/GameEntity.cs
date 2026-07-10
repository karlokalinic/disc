using System;
using System.Runtime.CompilerServices;
using Sunshine;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.EventSystems;

namespace FortressOccident
{
	public class GameEntity : Interactable, IPointerClickHandler, IEventSystemHandler
	{
		protected static GameEntity activeEntity;

		protected static NavMeshPath _navPath;

		protected static Vector3[] _navPathCorners;

		[SerializeField]
		protected float _interactionRadius;

		protected virtual float interactionRadius => 0f;

		public virtual Vector3 InteractionCenterPoint => default(Vector3);

		public virtual bool IsActive
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public event Action<bool> ActivationEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static void Deactivate()
		{
		}

		public static bool IsActiveEntityNull()
		{
			return false;
		}

		public bool CheckIfCanCreatePathToHavePath(Formation.Location currentLocation)
		{
			return false;
		}

		public Formation.Location GetInteractionLocation(Formation.Location currentLocation)
		{
			return default(Formation.Location);
		}

		public override bool Interact(ClickEventData data)
		{
			return false;
		}

		public bool IsWithinInteractionRadius(Vector3 point)
		{
			return false;
		}

		protected virtual void SendActivationEvent(bool active)
		{
		}

		protected void OnDrawGizmosSelected()
		{
		}

		public void OnPointerClick(PointerEventData eventData)
		{
		}
	}
}

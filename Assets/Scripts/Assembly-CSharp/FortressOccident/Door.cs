using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Voidforge;

namespace FortressOccident
{
	public class Door : BasicEntity
	{
		public static bool ENABLE_DOOR_USE_ANIMATION;

		[SerializeField]
		private Vector3 openRotation;

		[SerializeField]
		private Vector3 closedRotation;

		public static Dictionary<string, bool> doorStates;

		private Quaternion doorOpen;

		protected Quaternion doorClose;

		private Quaternion doorDest;

		public float doorAnimSpeed;

		private ComponentRef<TweenTransform> tween;

		protected bool isInTransition;

		protected bool ignoreNextSoundPlay;

		private static readonly int genericInteract;

		private bool _isLocked;

		private bool _isOpen;

		public bool IsInTransition => false;

		public bool IsLocked
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public virtual bool IsOpen
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		protected override void OnAwakeInitialized()
		{
		}

		protected override void OnStartInitialized()
		{
		}

		protected virtual void UpdateDoorState()
		{
		}

		protected override void OnSceneActivated()
		{
		}

		protected override void OnSceneDeactivated()
		{
		}

		protected override void OnEnable()
		{
		}

		private void CheckIfDoorIsOpen()
		{
		}

		protected virtual void CloseDoorsOnLevelTransition()
		{
		}

		public override void OnUse(Transform user = null)
		{
		}

		protected override bool CanPlayDialogue()
		{
			return false;
		}

		protected virtual void VisualTransitionDoor()
		{
		}

		public virtual void UseAnimation(Transform user)
		{
		}

		protected string GetDoorIdentifier()
		{
			return null;
		}

		private IEnumerator MoveDoor()
		{
			return null;
		}

		public void PlayDoorSound(string sound)
		{
		}

		public static void PlayDoorSoundStatic(string sound)
		{
		}

		public static void ClearDoorStates()
		{
		}
	}
}

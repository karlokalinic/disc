using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using PixelCrushers.DialogueSystem.UnityGUI;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	public class ProximitySelector : MonoBehaviour
	{
		[Serializable]
		public class Reticle
		{
			public Texture2D inRange;

			public Texture2D outOfRange;

			public float width;

			public float height;
		}

		public bool useDefaultGUI;

		public GUISkin guiSkin;

		public string guiStyleName;

		public TextAnchor alignment;

		public Color color;

		public TextStyle textStyle;

		public Color textStyleColor;

		public string defaultUseMessage;

		public KeyCode useKey;

		public string useButton;

		public bool enableTouch;

		public ScaledRect touchArea;

		public bool broadcastToChildren;

		public Transform actorTransform;

		public UsableUnityEvent onSelectedUsable;

		public UsableUnityEvent onDeselectedUsable;

		protected List<Usable> usablesInRange;

		protected Usable currentUsable;

		protected string currentHeading;

		protected string currentUseMessage;

		protected bool toldListenersHaveUsable;

		protected GUIStyle guiStyle;

		protected float guiStyleLineHeight;

		protected const float MinTimeBetweenUseButton = 0.5f;

		protected float timeToEnableUseButton;

		public Usable CurrentUsable => null;

		public GUIStyle GuiStyle => null;

		public event SelectedUsableObjectDelegate SelectedUsableObject
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

		public event DeselectedUsableObjectDelegate DeselectedUsableObject
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

		public virtual void Start()
		{
		}

		public virtual void OnConversationStart(Transform actor)
		{
		}

		public virtual void OnConversationEnd(Transform actor)
		{
		}

		protected virtual void Update()
		{
		}

		protected void OnSelectedUsableObject(Usable usable)
		{
		}

		protected void OnDeselectedUsableObject(Usable usable)
		{
		}

		public virtual void UseCurrentSelection()
		{
		}

		protected virtual bool IsUseButtonDown()
		{
			return false;
		}

		protected bool IsTouchDown()
		{
			return false;
		}

		protected void OnTriggerEnter(Collider other)
		{
		}

		protected void OnTriggerExit(Collider other)
		{
		}

		protected virtual void CheckTriggerEnter(GameObject other)
		{
		}

		protected virtual void CheckTriggerExit(GameObject other)
		{
		}

		public virtual void RemoveGameObjectFromDetectedList(GameObject other)
		{
		}

		public virtual void RemoveUsableFromDetectedList(Usable usable)
		{
		}

		protected virtual void SetCurrentUsable(Usable usable)
		{
		}

		public virtual void OnGUI()
		{
		}

		protected void SetGuiStyle()
		{
		}
	}
}

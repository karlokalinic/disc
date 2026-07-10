using System;
using System.Runtime.CompilerServices;
using PixelCrushers.DialogueSystem.UnityGUI;
using UnityEngine;
using UnityEngine.Events;

namespace PixelCrushers.DialogueSystem
{
	public class Selector : MonoBehaviour
	{
		[Serializable]
		public class Reticle
		{
			public Texture2D inRange;

			public Texture2D outOfRange;

			public float width;

			public float height;
		}

		public enum SelectAt
		{
			CenterOfScreen = 0,
			MousePosition = 1,
			CustomPosition = 2
		}

		public enum DistanceFrom
		{
			Camera = 0,
			GameObject = 1
		}

		public enum Dimension
		{
			In2D = 0,
			In3D = 1
		}

		private static LayerMask DefaultLayer;

		public SelectAt selectAt;

		public LayerMask layerMask;

		public DistanceFrom distanceFrom;

		public float maxSelectionDistance;

		public Dimension runRaycasts;

		public bool raycastAll;

		public bool useDefaultGUI;

		public GUISkin guiSkin;

		public string guiStyleName;

		public TextAnchor alignment;

		public TextStyle textStyle;

		public Color textStyleColor;

		public Color inRangeColor;

		public Color outOfRangeColor;

		public Reticle reticle;

		public KeyCode useKey;

		public string useButton;

		public string defaultUseMessage;

		public bool broadcastToChildren;

		public Transform actorTransform;

		public string tooFarMessage;

		public UsableUnityEvent onSelectedUsable;

		public UsableUnityEvent onDeselectedUsable;

		public UnityEvent tooFarEvent;

		public bool debug;

		protected GameObject selection;

		protected Usable usable;

		protected GameObject clickedDownOn;

		protected string heading;

		protected string useMessage;

		protected float distance;

		protected GUIStyle guiStyle;

		protected float guiStyleLineHeight;

		protected Ray lastRay;

		protected RaycastHit lastHit;

		protected RaycastHit[] lastHits;

		protected int numLastHits;

		private const int MaxHits = 100;

		public Vector3 CustomPosition { get; set; }

		public Usable CurrentUsable => null;

		public float CurrentDistance => 0f;

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

		protected virtual void Update()
		{
		}

		public virtual void UseCurrentSelection()
		{
		}

		protected virtual void Run2DRaycast()
		{
		}

		protected virtual void Run3DRaycast()
		{
		}

		protected void OnSelectedUsableObject(Usable usable)
		{
		}

		protected void OnDeselectedUsableObject(Usable usable)
		{
		}

		protected virtual void DeselectTarget()
		{
		}

		protected virtual bool IsUseButtonDown()
		{
			return false;
		}

		protected virtual Vector3 GetSelectionPoint()
		{
			return default(Vector3);
		}

		public virtual void OnGUI()
		{
		}

		protected void SetGuiStyle()
		{
		}

		public virtual void OnDrawGizmos()
		{
		}
	}
}

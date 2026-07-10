using System;
using System.Collections.Generic;
using Sunshine.Metric;
using UnityEngine;
using UnityEngine.EventSystems;

namespace FortressOccident
{
	public class MouseOverHighlight : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		[NonSerialized]
		public bool colorOverride;

		[NonSerialized]
		public Color colorCustom;

		[NonSerialized]
		public OutlineIndex outlineIndex;

		[NonSerialized]
		public static List<MouseOverHighlight> registry;

		public bool isOutlined;

		public bool lastMouseover;

		private Collider[] m_collider;

		private Renderer[] renderers;

		private Material[][] materials;

		private Material[][] instancedMaterials;

		private Dictionary<Material, float> materialOriginalIsFilledValue;

		private GameEntity[] gameEntities;

		private static readonly int isContainer;

		private static readonly int index;

		private static readonly int hasMouseoverScript;

		private static readonly int overrideOutlineColor;

		private static readonly int outlineColor;

		public bool highlightState;

		public static bool tab;

		public bool HaveAnyColliders => false;

		public Collider ColliderComponent => null;

		public GameEntity[] GameEntityInstance => null;

		public void Start()
		{
		}

		public void RefreshHighlightMaterials()
		{
		}

		private void TurnOffHighlight()
		{
		}

		public GameEntity GetFirstActive()
		{
			return null;
		}

		public bool InteractFirstActive(Interactable.ClickEventData eventData)
		{
			return false;
		}

		private void OnDestroy()
		{
		}

		public void OnEnable()
		{
		}

		public void OnDisable()
		{
		}

		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		public void OnPointerExit(PointerEventData eventData)
		{
		}

		public void SetHighlight(bool mouseover, bool isInRange = false)
		{
		}

		public static void UpdateHighlights(bool _tab)
		{
		}

		public void SetCustomColor(AbilityType ability)
		{
		}

		public void SetCustomColor(OutlineIndex ind)
		{
		}

		public bool IsAccessible()
		{
			return false;
		}

		public void SwapMaterials(Material[] oldMaterials, Material[] newMaterials)
		{
		}

		private void RegisterAndTurnMeOff()
		{
		}
	}
}

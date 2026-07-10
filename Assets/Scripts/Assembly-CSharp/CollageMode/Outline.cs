using System;
using FortressOccident;
using UnityEngine;

namespace CollageMode
{
	public class Outline : MonoBehaviour
	{
		[NonSerialized]
		public bool colorOverride;

		[NonSerialized]
		public Color colorCustom;

		[NonSerialized]
		public OutlineIndex outlineIndex;

		private Renderer[] renderers;

		private Material[][] materials;

		private Material[][] instancedMaterials;

		private static readonly int isContainer;

		private static readonly int index;

		private static readonly int hasMouseoverScript;

		private static readonly int overrideOutlineColor;

		private static readonly int outlineColor;

		public void Start()
		{
		}

		public void RefreshHighlightMaterials()
		{
		}

		public void SetHighlight(bool isHighlighted)
		{
		}

		public void SetFilled(bool isFilled, Color color)
		{
		}

		private void SwapMaterials(Material[] oldMaterials, Material[] newMaterials)
		{
		}
	}
}

using System;
using UnityEngine;
using UnityEngine.UI;

namespace CollageMode
{
	public class Highlighter : MonoBehaviour
	{
		[Serializable]
		private struct ChangeColorData
		{
			public Graphic Graphic;

			public Color ColorHighlighted;

			public Color ColorNotHighlighted;
		}

		[SerializeField]
		private ChangeColorData[] changeColor;

		[SerializeField]
		private GameObject[] gameObjectsToEnable;

		[SerializeField]
		private bool setNotHighlightedColor;

		private void Awake()
		{
		}

		public void SetHighlight(bool isOn)
		{
		}
	}
}

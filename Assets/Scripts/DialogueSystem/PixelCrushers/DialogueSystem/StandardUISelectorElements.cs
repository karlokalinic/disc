using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace PixelCrushers.DialogueSystem
{
	public class StandardUISelectorElements : MonoBehaviour
	{
		[Serializable]
		public class AnimationTransitions
		{
			public string showTrigger;

			public string hideTrigger;
		}

		public Graphic mainGraphic;

		public UITextField nameText;

		public UITextField useMessageText;

		public Color inRangeColor;

		public Color outOfRangeColor;

		public Graphic reticleInRange;

		public Graphic reticleOutOfRange;

		public AnimationTransitions animationTransitions;

		private static List<StandardUISelectorElements> m_instances;

		public Animator animator { get; private set; }

		public static List<StandardUISelectorElements> instances => null;

		public static StandardUISelectorElements instance => null;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}
	}
}

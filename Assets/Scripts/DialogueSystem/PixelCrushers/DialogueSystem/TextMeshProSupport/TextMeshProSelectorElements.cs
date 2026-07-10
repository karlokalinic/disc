using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace PixelCrushers.DialogueSystem.TextMeshProSupport
{
	public class TextMeshProSelectorElements : MonoBehaviour
	{
		public Graphic mainGraphic;

		public TextMeshProUGUI nameText;

		public TextMeshProUGUI useMessageText;

		public Color inRangeColor;

		public Color outOfRangeColor;

		public Graphic reticleInRange;

		public Graphic reticleOutOfRange;

		public TextMeshProSelectorDisplay.AnimationTransitions animationTransitions;

		public static TextMeshProSelectorElements instance;

		private void Awake()
		{
		}
	}
}

using PixelCrushers.DialogueSystem.UnityGUI;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	public class SelectorFollowTarget : MonoBehaviour
	{
		public Vector3 offset;

		private Selector selector;

		private ProximitySelector proximitySelector;

		private bool previousUseDefaultGUI;

		private Usable lastUsable;

		private string heading;

		private string useMessage;

		private GameObject lastSelectionDrawn;

		private float selectionHeight;

		private Vector2 selectionHeadingSize;

		private Vector2 selectionUseMessageSize;

		private SelectorUseStandardUIElements selectorUseStandardUIElements;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public virtual void Update()
		{
		}

		public virtual void OnGUI()
		{
		}

		protected void DrawOnSelection(Usable usable, float distance, Selector.Reticle reticle, GUIStyle guiStyle, string defaultUseMessage, Color inRangeColor, Color outOfRangeColor, TextStyle textStyle, Color textStyleColor)
		{
		}
	}
}

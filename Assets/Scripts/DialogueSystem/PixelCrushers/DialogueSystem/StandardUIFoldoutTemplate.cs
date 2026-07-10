using UnityEngine;
using UnityEngine.UI;

namespace PixelCrushers.DialogueSystem
{
	public class StandardUIFoldoutTemplate : StandardUIContentTemplate
	{
		public Button foldoutButton;

		public UITextField foldoutText;

		public RectTransform interiorPanel;

		protected StandardUIInstancedContentManager contentManager { get; set; }

		public virtual void Awake()
		{
		}

		public void Assign(string text, bool expanded)
		{
		}

		public void ToggleInterior()
		{
		}
	}
}

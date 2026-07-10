using UnityEngine;

namespace PixelCrushers.DialogueSystem.UnityGUI
{
	public class GUIVisibleControl : GUIControl
	{
		public LocalizedTextTable localizedText;

		public string text;

		public string guiStyleName;

		private FormattedText formattingToApply;

		private bool isFormattingApplied;

		private GUIStyle guiStyle;

		private Color originalGUIColor;

		private float alpha;

		private string originalTextValue;

		public float Alpha
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool HasAlpha => false;

		protected virtual GUIStyle DefaultGUIStyle => null;

		protected GUIStyle GuiStyle
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override void Awake()
		{
		}

		public virtual void Start()
		{
		}

		public void UseLocalizedText(LocalizedTextTable localizedText)
		{
		}

		public void ApplyAlphaToGUIColor()
		{
		}

		public void RestoreGUIColor()
		{
		}

		public virtual void SetFormattedText(FormattedText formattedText)
		{
		}

		public void SetUnformattedText(string text)
		{
		}

		public override void UpdateLayoutSelf()
		{
		}

		protected void SetGUIStyle()
		{
		}

		protected void ApplyFormatting()
		{
		}

		public override void AutoSizeSelf()
		{
		}

		private float GetAutoSizeX(float width)
		{
			return 0f;
		}

		private float GetAutoSizeY(float height)
		{
			return 0f;
		}

		public void PlaySound(AudioClip audioClip)
		{
		}
	}
}

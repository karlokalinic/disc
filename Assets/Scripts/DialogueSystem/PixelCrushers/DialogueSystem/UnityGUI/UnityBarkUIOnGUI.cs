using System.Collections;
using UnityEngine;

namespace PixelCrushers.DialogueSystem.UnityGUI
{
	public class UnityBarkUIOnGUI : MonoBehaviour
	{
		public Vector3 offset;

		public float maxWidth;

		protected GUISkin guiSkin;

		protected string guiStyleName;

		protected GUIStyle guiStyle;

		protected FormattedText formattingToApply;

		protected TextStyle textStyle;

		protected Color textStyleColor;

		protected Vector2 size;

		protected string message;

		protected float alpha;

		protected Transform myTransform;

		protected Transform absolutePosition;

		protected Vector3 offsetToHead;

		protected Vector3 screenPos;

		public bool IsPlaying => false;

		public Vector3 BarkPosition { get; private set; }

		public virtual void Awake()
		{
		}

		public virtual void Start()
		{
		}

		protected void ComputeOffsetToHead()
		{
		}

		public virtual void Show(Subtitle subtitle, float duration, GUISkin guiSkin, string guiStyleName, TextStyle textStyle, bool includeName, Transform textPosition)
		{
		}

		public virtual void Show(Subtitle subtitle, float duration, GUISkin guiSkin, string guiStyleName, TextStyle textStyle, Color textStyleColor, bool includeName, Transform textPosition)
		{
		}

		public IEnumerator FadeOut(float fadeDuration)
		{
			return null;
		}

		public virtual void OnGUI()
		{
		}

		protected void UpdateBarkPosition()
		{
		}
	}
}

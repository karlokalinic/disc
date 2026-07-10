using System.Text;
using FortressOccident;
using I2.Loc;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Voidforge;

namespace Sunshine
{
	public class ParagraphText : FOComponent, ILayoutController, ILayoutElement, IClippable
	{
		private const char NonBreakingSpace = '\u00a0';

		private static readonly StringBuilder stringBuilder;

		[SerializeField]
		[TextArea]
		protected string paragraphText;

		[SerializeField]
		protected TextMeshProUGUI firstLine;

		[SerializeField]
		private Localize firstLineLocalizeFont;

		[SerializeField]
		private Localize firstLineLocalizeMaterial;

		[SerializeField]
		protected TextMeshProUGUI moreLines;

		[SerializeField]
		private Localize moreLinesLocalizeFont;

		[SerializeField]
		private Localize moreLinesLocalizeMaterial;

		[SerializeField]
		protected float paragraphOffset;

		[SerializeField]
		public bool indented;

		[SerializeField]
		public LayoutElement layoutElement;

		private bool isNew;

		private int cachedFirstLineSplit;

		public float fontSize
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public FontStyles fontStyle
		{
			get
			{
				return default(FontStyles);
			}
			set
			{
			}
		}

		public Color color
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public Material material
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool verticalOverflow
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float flexibleWidth => 0f;

		public float flexibleHeight => 0f;

		public int layoutPriority => 0;

		public float minWidth => 0f;

		public float minHeight => 0f;

		public float preferredHeight => 0f;

		public float preferredWidth => 0f;

		public bool resizeTextForBestFit
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public string text
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public RectTransform rectTransform => null;

		public bool IsNew
		{
			set
			{
			}
		}

		GameObject IClippable.gameObject => null;

		public void SetLayoutHorizontal()
		{
		}

		public void SetLayoutVertical()
		{
		}

		public void FixHeight(RectTransform target, float height)
		{
		}

		public void CalculateLayoutInputHorizontal()
		{
		}

		public void CalculateLayoutInputVertical()
		{
		}

		public void RecalculateMasking()
		{
		}

		public void RecalculateClipping()
		{
		}

		public void Cull(Rect clipRect, bool validRect)
		{
		}

		public void SetClipRect(Rect value, bool validRect)
		{
		}

		public void SetClipSoftness(Vector2 clipSoftness)
		{
		}

		private float ParentWidth()
		{
			return 0f;
		}

		protected void Parse()
		{
		}

		private void ParseDual()
		{
		}

		private void ParseDualRTL()
		{
		}

		private string InvertRTLLines(RichTextParser parsedText)
		{
			return null;
		}

		private bool HasText(RichTextParser parsedText)
		{
			return false;
		}

		private string SplitLine(string text, RichTextParser parsedText, out RichTextParser remainingText)
		{
			remainingText = null;
			return null;
		}

		private void ParseDualLTR()
		{
		}

		private void ParseIndented()
		{
		}

		private void SetLineText(int line, string value)
		{
		}

		private void UpdateLayoutElementHeight()
		{
		}

		protected override void Awake()
		{
		}

		protected void OnEnable()
		{
		}

		protected void OnDisable()
		{
		}

		protected void OnTextSizeChanged(TextSizeConfiguration.TextSize textSize)
		{
		}

		private void SetText()
		{
		}
	}
}

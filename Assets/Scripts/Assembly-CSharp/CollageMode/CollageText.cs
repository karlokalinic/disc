using System;
using System.Collections;
using I2.Loc;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace CollageMode
{
	public class CollageText : CollageElement
	{
		[Serializable]
		public struct Padding
		{
			public float Left;

			public float Right;

			public float Top;

			public float Bottom;
		}

		public new class InitData : CollageElement.InitData
		{
			public Vector3 Position;

			public string PlaceTextOperationIdentifier;

			public string Text
			{
				get
				{
					return null;
				}
				set
				{
				}
			}
		}

		[SerializeField]
		private Canvas canvas;

		[SerializeField]
		private TMP_InputField inputField;

		[SerializeField]
		private Localize inputFieldLocalize;

		[SerializeField]
		private RectTransform textArea;

		[SerializeField]
		private Image background;

		[SerializeField]
		private GameObject selection;

		private Image selectionImage;

		private string previousText;

		private string font;

		public override string DisplayTerm => null;

		public string PlaceTextOperationIdentifier { get; set; }

		public override bool UsesSortingOrder => false;

		public override int SortingOrder
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public string Text
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public float FontSize
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public Padding TextPadding
		{
			get
			{
				return default(Padding);
			}
			set
			{
			}
		}

		public FontWeight FontWeight
		{
			get
			{
				return default(FontWeight);
			}
			set
			{
			}
		}

		public string Font
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Color Color
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public Color BackgroundColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public Sprite BackgroundSprite
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected override void Awake()
		{
		}

		public override void Init(CollageElement.InitData initData)
		{
		}

		public override CollageElement.InitData GetInitData()
		{
			return null;
		}

		public void Edit()
		{
		}

		protected override void InitialPlacementSubmitted()
		{
		}

		protected override void MoveStarted()
		{
		}

		protected override void MoveSubmitted()
		{
		}

		protected override void Clicked()
		{
		}

		protected override void RefreshSelectionVisual(bool isSelected)
		{
		}

		private void OnEndEdit(string newText)
		{
		}

		private char OnValidateInput(string text, int charIndex, char addedChar)
		{
			return '\0';
		}

		private IEnumerator OnEndEditCoroutine()
		{
			return null;
		}
	}
}

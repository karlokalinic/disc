using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Voidforge
{
	public class RichTextParser
	{
		[Serializable]
		public abstract class Token
		{
			[HideInInspector]
			public bool connectedToPrevious;

			[HideInInspector]
			public bool connectedToNext;

			public Token()
			{
			}
		}

		[Serializable]
		public abstract class SimpleToken : Token
		{
			[SerializeField]
			protected string _value;

			public SimpleToken(string text)
			{
			}

			public override string ToString()
			{
				return null;
			}
		}

		[Serializable]
		public class Text : SimpleToken
		{
			public Text(string text)
				: base(null)
			{
			}
		}

		[Serializable]
		public class Separator : SimpleToken
		{
			public bool IsNewLine => false;

			public Separator(string text)
				: base(null)
			{
			}

			public Separator(char c)
				: base(null)
			{
			}

			public static implicit operator char(Separator separator)
			{
				return '\0';
			}

			public static bool IsSeparator(char c)
			{
				return false;
			}
		}

		[Serializable]
		public class Tag : Token
		{
			public enum Format
			{
				UNITY = 0,
				BBCODE = 1,
				HTML = 2
			}

			public enum Mode
			{
				OPENING = 0,
				CLOSING = 1,
				SELF_CLOSING = 2
			}

			protected enum TagParseState
			{
				TOKEN = 0,
				VALUE = 1,
				VALUE_DOUBLEQUOTES = 2,
				VALUE_SINGLEQUOTES = 3
			}

			[SerializeField]
			protected Format _format;

			[SerializeField]
			protected bool _isValid;

			[SerializeField]
			protected Mode _mode;

			public virtual Format format
			{
				get
				{
					return default(Format);
				}
				set
				{
				}
			}

			public bool isValid
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public Mode mode
			{
				get
				{
					return default(Mode);
				}
				set
				{
				}
			}

			public Tag other { get; set; }

			public static Token Create(string rawValue, Format suggestedFormat)
			{
				return null;
			}
		}

		[Serializable]
		public class BoldTag : Tag
		{
			public override string ToString()
			{
				return null;
			}
		}

		[Serializable]
		public class ItalicTag : Tag
		{
			public override string ToString()
			{
				return null;
			}
		}

		[Serializable]
		public class ColorTag : Tag
		{
			[SerializeField]
			protected Color32 _color;

			public Color32 color
			{
				get
				{
					return default(Color32);
				}
				set
				{
				}
			}

			public override string ToString()
			{
				return null;
			}
		}

		[Serializable]
		public class SizeTag : Tag
		{
			[SerializeField]
			protected int _size;

			public int size
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public override string ToString()
			{
				return null;
			}
		}

		[Serializable]
		public class UnknownTag : Tag
		{
			[SerializeField]
			protected string _rawValue;

			public string value
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public override string ToString()
			{
				return null;
			}
		}

		protected enum ParseState
		{
			NORMAL = 0,
			TAG = 1,
			TAG_DOUBLEQUOTES = 2,
			TAG_SINGLEQUOTES = 3
		}

		protected List<Token> tokens;

		private static readonly StringBuilder sb;

		public Token Item
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int Count => 0;

		public RichTextParser()
		{
		}

		public RichTextParser(string text, params Tag.Format[] supportedFormats)
		{
		}

		public void Add(Token t)
		{
		}

		public RichTextParser First(int count)
		{
			return null;
		}

		public void LinkMatchingTags()
		{
		}

		public bool Split(int position, out RichTextParser first, out RichTextParser second)
		{
			first = null;
			second = null;
			return false;
		}

		public override string ToString()
		{
			return null;
		}

		protected void SetSupportedFormats(Tag.Format[] supportedFormats, out bool allowUnity, out bool allowBBCode, out bool allowHTML)
		{
			allowUnity = default(bool);
			allowBBCode = default(bool);
			allowHTML = default(bool);
		}
	}
}

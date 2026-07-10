using System;

namespace Voidforge
{
	public class ChineseRichTextParser : RichTextParser
	{
		[Serializable]
		public class ChineseTag : Tag
		{
			public new static Token Create(string rawValue, Format suggestedFormat)
			{
				return null;
			}
		}

		[Serializable]
		public class ChineseSeparator : Separator
		{
			public ChineseSeparator(string text)
				: base(null)
			{
			}

			public ChineseSeparator(char c)
				: base(null)
			{
			}

			public new static bool IsSeparator(char c)
			{
				return false;
			}
		}

		public ChineseRichTextParser(string text, params Tag.Format[] supportedFormats)
		{
		}
	}
}

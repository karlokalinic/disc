using System.Collections.Generic;

namespace Language.Lua
{
	public class TextInput : ParserInput<char>
	{
		private string InputText;

		private List<int> LineBreaks;

		public int Length => 0;

		public TextInput(string text)
		{
		}

		public bool HasInput(int pos)
		{
			return false;
		}

		public char GetInputSymbol(int pos)
		{
			return '\0';
		}

		public char[] GetSubSection(int position, int length)
		{
			return null;
		}

		public string FormErrorMessage(int position, string message)
		{
			return null;
		}

		public void GetLineColumnNumber(int pos, out int line, out int col)
		{
			line = default(int);
			col = default(int);
		}

		public string GetSubString(int start, int length)
		{
			return null;
		}
	}
}

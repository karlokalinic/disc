using System.Collections.Generic;
using System.IO;
using PixelCrushers.DialogueSystem.SequencerCommands;

namespace PixelCrushers.DialogueSystem
{
	public class SequenceParser
	{
		private const int MaxSafeguard = 9999;

		private int column;

		private int row;

		public List<QueuedSequencerCommand> Parse(string sequence)
		{
			return null;
		}

		private QueuedSequencerCommand ParseCommand(StringReader reader)
		{
			return null;
		}

		private string ParseWord(StringReader reader, bool allowWhiteSpace = false)
		{
			return null;
		}

		private void ParseOptionalWhitespace(StringReader reader, bool includingSemicolons = false)
		{
		}

		private bool IsNextCharWhiteSpace(StringReader reader)
		{
			return false;
		}

		private bool IsNextChar(StringReader reader, char requiredChar)
		{
			return false;
		}

		private bool IsNextCharNot(StringReader reader, char requiredChar)
		{
			return false;
		}

		private bool HasNextChar(StringReader reader)
		{
			return false;
		}

		private char ReadNextChar(StringReader reader)
		{
			return '\0';
		}

		private void ParseChar(StringReader reader, char requiredChar)
		{
		}

		private void ParseOpenParen(StringReader reader)
		{
		}

		private void ParseCloseParen(StringReader reader)
		{
		}

		private string[] ParseParameters(StringReader reader)
		{
			return null;
		}

		private string ParseParameter(StringReader reader)
		{
			return null;
		}

		private void ParsePostParameters(StringReader reader, out float atTime, out string atMessage, out string sendMessage)
		{
			atTime = default(float);
			atMessage = null;
			sendMessage = null;
		}

		private void ParseAtSignModifier(StringReader reader, out float atTime, out string atMessage)
		{
			atTime = default(float);
			atMessage = null;
		}

		private void ParseArrowModifier(StringReader reader, out string sendMessage)
		{
			sendMessage = null;
		}

		private void ParseSemicolonOrEnd(StringReader reader)
		{
		}
	}
}

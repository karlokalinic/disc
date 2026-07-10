using System.Text;

namespace InControl.Internal
{
	public class CodeWriter
	{
		private const char newLine = '\n';

		private int indent;

		private readonly StringBuilder stringBuilder;

		public void IncreaseIndent()
		{
		}

		public void DecreaseIndent()
		{
		}

		public void Append(string code)
		{
		}

		public void Append(bool trim, string code)
		{
		}

		public void AppendLine(string code)
		{
		}

		public void AppendLine(int count)
		{
		}

		public void AppendFormat(string format, params object[] args)
		{
		}

		public void AppendLineFormat(string format, params object[] args)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}

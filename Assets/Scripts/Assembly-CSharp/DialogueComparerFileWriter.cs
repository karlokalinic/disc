using System.Collections.Generic;
using System.IO;

public class DialogueComparerFileWriter
{
	private StreamWriter OutputFile;

	private List<string> LastPath;

	private const string HEADER_SEPARATOR = "  ->  ";

	public DialogueComparerFileWriter(StreamWriter file)
	{
	}

	public void WriteHeader(string header, int level)
	{
	}

	public void WriteToFile(string identifier, string value1, string value2, List<string> path)
	{
	}

	private void WriteHeaders(List<string> path)
	{
	}

	private static string JoinHeader(List<string> path, int upToIndex)
	{
		return null;
	}

	private static string JoinHeader(List<string> headers)
	{
		return null;
	}
}

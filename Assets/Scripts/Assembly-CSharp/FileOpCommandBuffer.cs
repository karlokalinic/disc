using System.Collections.Generic;

public class FileOpCommandBuffer
{
	private Queue<FileOp> queue;

	private List<FileOp> failed;

	public bool AllGood => false;

	public int NumOfFailedOps => 0;

	public void CreateFile(string path, byte[] bytes, int count = 0)
	{
	}

	public void DeleteFile(string path)
	{
	}

	public void MoveFile(string oldPath, string newPath)
	{
	}

	public FileOpReadData ReadFile(string path, int capacity)
	{
		return null;
	}

	public void Execute(string mountPath)
	{
	}
}

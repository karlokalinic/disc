public class ReadFileOp : FileOp
{
	private string filePath;

	private FileOpReadData data;

	public FileOpReadData Data => null;

	public ReadFileOp(string path, int capacity)
		: base(default(FileOpType))
	{
	}

	public override FileOpResultCode Execute(string mountPath)
	{
		return default(FileOpResultCode);
	}
}

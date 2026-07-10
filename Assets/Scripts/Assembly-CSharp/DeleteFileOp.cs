public class DeleteFileOp : FileOp
{
	private string filePath;

	public DeleteFileOp(string path)
		: base(default(FileOpType))
	{
	}

	public override FileOpResultCode Execute(string mountPath)
	{
		return default(FileOpResultCode);
	}
}

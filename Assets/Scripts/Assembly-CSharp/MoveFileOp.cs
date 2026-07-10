public class MoveFileOp : FileOp
{
	private string oldFilePath;

	private string newFilePath;

	public MoveFileOp(string oldPath, string newPath)
		: base(default(FileOpType))
	{
	}

	public override FileOpResultCode Execute(string mountPath)
	{
		return default(FileOpResultCode);
	}
}

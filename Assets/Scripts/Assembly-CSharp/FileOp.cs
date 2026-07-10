public class FileOp
{
	public static readonly int MaxPathSize;

	private FileOpType type;

	public FileOpType Type => default(FileOpType);

	public FileOp(FileOpType type)
	{
	}

	public virtual FileOpResultCode Execute(string mountPath)
	{
		return default(FileOpResultCode);
	}
}

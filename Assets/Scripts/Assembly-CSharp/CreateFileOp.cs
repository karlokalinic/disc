public class CreateFileOp : FileOp
{
	private string filePath;

	private byte[] bytes;

	private int count;

	public CreateFileOp(string path, byte[] bytes, int count)
		: base(default(FileOpType))
	{
	}

	public override FileOpResultCode Execute(string mountPath)
	{
		return default(FileOpResultCode);
	}
}

public class Pool<T> : BasePool<T> where T : class, new()
{
	public Pool(int capacity)
		: base(0)
	{
	}

	protected override object New()
	{
		return null;
	}
}

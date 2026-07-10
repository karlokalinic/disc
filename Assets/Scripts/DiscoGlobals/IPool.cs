public abstract class IPool
{
	public abstract int Capacity { get; }

	public abstract int FreeCount { get; }

	protected abstract object New();

	protected abstract void ExpandCapacity(int capacity);

	public abstract object Get();

	public abstract void Return(object obj);
}

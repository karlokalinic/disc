namespace Voidforge
{
	public abstract class TweenValue<T> : Tween
	{
		public new abstract T Item { get; }

		public T value => default(T);
	}
}

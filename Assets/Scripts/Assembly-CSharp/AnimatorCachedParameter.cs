using UnityEngine;

public abstract class AnimatorCachedParameter<T>
{
	protected readonly string name;

	protected readonly Animator animator;

	protected T value;

	protected bool hasValue;

	public AnimatorCachedParameter(Animator animator, string name)
	{
	}

	public T Get()
	{
		return default(T);
	}

	public void Set(T value)
	{
	}

	public abstract void RefreshValue();
}

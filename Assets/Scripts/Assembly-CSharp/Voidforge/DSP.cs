using System;

namespace Voidforge
{
	public class DSP<T>
	{
		protected Func<T, T, float, T> _aggregatorFunc;

		protected float[] _kernel;

		protected T[] _inputs;

		protected int _inputIndex;

		protected bool _isCalculated;

		protected T _output;

		public int size => 0;

		public virtual T value => default(T);

		public DSP(int size, Func<T, T, float, T> aggregator)
		{
		}

		public virtual bool Add(T newValue)
		{
			return false;
		}

		public virtual void Reset()
		{
		}
	}
}

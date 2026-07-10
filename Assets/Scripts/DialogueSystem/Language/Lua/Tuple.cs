namespace Language.Lua
{
	public static class Tuple
	{
		public static Tuple<T1, T2> Create<T1, T2>(T1 item1, T2 item2)
		{
			return null;
		}

		public static Tuple<T1, T2, T3> Create<T1, T2, T3>(T1 item1, T2 item2, T3 item3)
		{
			return null;
		}
	}
	public sealed class Tuple<T1, T2>
	{
		private readonly T1 item1;

		private readonly T2 item2;

		public T1 Item1 => default(T1);

		public T2 Item2 => default(T2);

		public Tuple(T1 item1, T2 item2)
		{
		}

		public override bool Equals(object o)
		{
			return false;
		}

		public static bool operator ==(Tuple<T1, T2> a, Tuple<T1, T2> b)
		{
			return false;
		}

		public static bool operator !=(Tuple<T1, T2> a, Tuple<T1, T2> b)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
	public sealed class Tuple<T1, T2, T3>
	{
		private readonly T1 item1;

		private readonly T2 item2;

		private readonly T3 item3;

		public T1 Item1 => default(T1);

		public T2 Item2 => default(T2);

		public T3 Item3 => default(T3);

		public Tuple(T1 item1, T2 item2, T3 item3)
		{
		}

		public override bool Equals(object o)
		{
			return false;
		}

		public static bool operator ==(Tuple<T1, T2, T3> a, Tuple<T1, T2, T3> b)
		{
			return false;
		}

		public static bool operator !=(Tuple<T1, T2, T3> a, Tuple<T1, T2, T3> b)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}

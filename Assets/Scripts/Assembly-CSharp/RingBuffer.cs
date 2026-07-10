public class RingBuffer<T>
{
	private int _writePointer;

	private int _readPointer;

	private int length;

	private T[] ring;

	private int WritePointer
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	private int ReadPointer
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public RingBuffer(int _length, T _initValue)
	{
	}

	public void Add(T data)
	{
	}

	public T Read()
	{
		return default(T);
	}

	public T Peek(int offset = 0)
	{
		return default(T);
	}

	public T[] GetFullData()
	{
		return null;
	}
}

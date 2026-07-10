namespace CollageMode
{
	public abstract class Command
	{
		public abstract void Execute(CollageMode collageMode);

		public virtual void Preview(CollageMode collageMode)
		{
		}

		public abstract void Undo(CollageMode collageMode);

		public virtual bool Validate(CollageMode collageMode)
		{
			return false;
		}

		public virtual void Dispose(CollageMode collageMode)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}

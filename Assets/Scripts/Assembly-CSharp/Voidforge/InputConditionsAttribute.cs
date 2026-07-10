namespace Voidforge
{
	public abstract class InputConditionsAttribute : InputAttribute
	{
		protected bool? _alt;

		protected bool? _control;

		protected bool? _shift;

		protected bool? _mouseLeft;

		protected bool? _mouseMiddle;

		protected bool? _mouseRight;

		public bool alt
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool control
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool shift
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool mouseLeft
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool mouseMiddle
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool mouseRight
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool onlyWhenSelected { get; set; }

		public virtual bool CanHandle(InputManager.EventData data)
		{
			return false;
		}

		public InputConditionsAttribute()
		{
		}
	}
}

using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace InControl
{
	public class TouchPool
	{
		public readonly ReadOnlyCollection<Touch> Touches;

		private List<Touch> usedTouches;

		private List<Touch> freeTouches;

		public TouchPool(int capacity)
		{
		}

		public TouchPool()
		{
		}

		public Touch FindOrCreateTouch(int fingerId)
		{
			return null;
		}

		public Touch FindTouch(int fingerId)
		{
			return null;
		}

		private Touch NewTouch()
		{
			return null;
		}

		public void FreeTouch(Touch touch)
		{
		}

		public void FreeEndedTouches()
		{
		}
	}
}

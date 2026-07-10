using InControl;

namespace CollageMode
{
	public class TwoAxisDragAction : DragAction
	{
		private const float SUBMIT_DELAY = 1f;

		private readonly PlayerOneAxisAction inputActionX;

		private readonly PlayerOneAxisAction inputActionY;

		private readonly bool accumulateValue;

		private float lastChangeTime;

		private bool enabled;

		public bool Enabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public TwoAxisDragAction(PlayerOneAxisAction inputActionX, PlayerOneAxisAction inputActionY = null, bool accumulateValue = true)
		{
		}

		public void Update()
		{
		}
	}
}

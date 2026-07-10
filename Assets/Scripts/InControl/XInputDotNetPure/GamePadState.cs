namespace XInputDotNetPure
{
	public struct GamePadState
	{
		internal struct RawState
		{
			public struct GamePad
			{
				public ushort dwButtons;

				public byte bLeftTrigger;

				public byte bRightTrigger;

				public short sThumbLX;

				public short sThumbLY;

				public short sThumbRX;

				public short sThumbRY;
			}

			public uint dwPacketNumber;

			public GamePad Gamepad;
		}

		private enum ButtonsConstants
		{
			DPadUp = 1,
			DPadDown = 2,
			DPadLeft = 4,
			DPadRight = 8,
			Start = 0x10,
			Back = 0x20,
			LeftThumb = 0x40,
			RightThumb = 0x80,
			LeftShoulder = 0x100,
			RightShoulder = 0x200,
			A = 0x1000,
			B = 0x2000,
			X = 0x4000,
			Y = 0x8000
		}

		private bool isConnected;

		private uint packetNumber;

		private GamePadButtons buttons;

		private GamePadDPad dPad;

		private GamePadThumbSticks thumbSticks;

		private GamePadTriggers triggers;

		public uint PacketNumber => 0u;

		public bool IsConnected => false;

		public GamePadButtons Buttons => default(GamePadButtons);

		public GamePadDPad DPad => default(GamePadDPad);

		public GamePadTriggers Triggers => default(GamePadTriggers);

		public GamePadThumbSticks ThumbSticks => default(GamePadThumbSticks);

		internal GamePadState(bool isConnected, RawState rawState)
		{
			this.isConnected = false;
			packetNumber = 0u;
			buttons = default(GamePadButtons);
			dPad = default(GamePadDPad);
			thumbSticks = default(GamePadThumbSticks);
			triggers = default(GamePadTriggers);
		}
	}
}

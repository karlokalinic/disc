namespace Steamworks
{
	public static class SteamInput
	{
		public static InputActionSetHandle_t GetCurrentActionSet(InputHandle_t inputHandle)
		{
			return default(InputActionSetHandle_t);
		}

		public static ESteamInputType GetInputTypeForHandle(InputHandle_t inputHandle)
		{
			return default(ESteamInputType);
		}

		public static InputHandle_t GetControllerForGamepadIndex(int nIndex)
		{
			return default(InputHandle_t);
		}
	}
}

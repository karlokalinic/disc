namespace UnityEngine.Timeline
{
	internal static class TimelineUndo
	{
		public static void PushDestroyUndo(TimelineAsset timeline, Object thingToDirty, Object objectToDestroy)
		{
		}

		public static void PushUndo(Object[] thingsToDirty, string operation)
		{
		}

		public static void PushUndo(Object thingToDirty, string operation)
		{
		}

		public static void RegisterCreatedObjectUndo(Object thingCreated, string operation)
		{
		}

		private static string UndoName(string name)
		{
			return null;
		}
	}
}

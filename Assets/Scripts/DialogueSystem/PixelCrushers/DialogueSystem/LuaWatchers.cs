namespace PixelCrushers.DialogueSystem
{
	public class LuaWatchers
	{
		private LuaWatchList m_everyUpdateList;

		private LuaWatchList m_everyDialogueEntryList;

		private LuaWatchList m_endOfConversationList;

		public void AddObserver(string luaExpression, LuaWatchFrequency frequency, LuaChangedDelegate luaChangedHandler)
		{
		}

		public void RemoveObserver(string luaExpression, LuaWatchFrequency frequency, LuaChangedDelegate luaChangedHandler)
		{
		}

		public void RemoveAllObservers(LuaWatchFrequency frequency)
		{
		}

		public void RemoveAllObservers()
		{
		}

		public void NotifyObservers(LuaWatchFrequency frequency)
		{
		}
	}
}

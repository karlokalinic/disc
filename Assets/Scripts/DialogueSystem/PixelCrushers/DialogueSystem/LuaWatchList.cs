using System.Collections.Generic;

namespace PixelCrushers.DialogueSystem
{
	public class LuaWatchList
	{
		private List<LuaWatchItem> m_watchList;

		public void AddObserver(string luaExpression, LuaChangedDelegate luaChangedHandler)
		{
		}

		public void RemoveObserver(string luaExpression, LuaChangedDelegate luaChangedHandler)
		{
		}

		public void RemoveAllObservers()
		{
		}

		public void NotifyObservers()
		{
		}
	}
}

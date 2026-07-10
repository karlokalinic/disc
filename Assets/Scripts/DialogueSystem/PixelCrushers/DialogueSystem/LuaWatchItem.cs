using System.Runtime.CompilerServices;

namespace PixelCrushers.DialogueSystem
{
	public class LuaWatchItem
	{
		private string m_currentValue;

		public string luaExpression { get; set; }

		public string LuaExpression
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private event LuaChangedDelegate luaChanged
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static string LuaExpressionWithReturn(string luaExpression)
		{
			return null;
		}

		public LuaWatchItem(string luaExpression, LuaChangedDelegate luaChangedHandler)
		{
		}

		public bool Matches(string luaExpression, LuaChangedDelegate luaChangedHandler)
		{
			return false;
		}

		public void Check()
		{
		}
	}
}

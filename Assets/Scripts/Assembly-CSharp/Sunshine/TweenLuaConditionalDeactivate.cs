using PixelCrushers.DialogueSystem;
using Voidforge;

namespace Sunshine
{
	public class TweenLuaConditionalDeactivate : TweenDeactivate
	{
		public string variable;

		protected Lua.Result luaVariable => default(Lua.Result);

		protected override void Start()
		{
		}
	}
}

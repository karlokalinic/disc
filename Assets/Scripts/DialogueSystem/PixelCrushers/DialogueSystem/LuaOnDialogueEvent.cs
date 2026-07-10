using System;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	public class LuaOnDialogueEvent : ActOnDialogueEvent
	{
		[Serializable]
		public class LuaAction : Action
		{
			[Multiline]
			public string luaCode;
		}

		public LuaAction[] onStart;

		public LuaAction[] onEnd;

		public bool debugLua;

		public override void TryStartActions(Transform actor)
		{
		}

		public override void TryEndActions(Transform actor)
		{
		}

		private void TryActions(LuaAction[] actions, Transform actor)
		{
		}

		public void DoAction(LuaAction action, Transform actor)
		{
		}
	}
}

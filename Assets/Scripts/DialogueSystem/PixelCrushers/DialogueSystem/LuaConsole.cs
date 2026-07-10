using System.Collections.Generic;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	public class LuaConsole : MonoBehaviour
	{
		public KeyCode firstKey;

		public KeyCode secondKey;

		public bool visible;

		public Vector2 minSize;

		public int maxHistory;

		public bool pauseGameWhileOpen;

		private List<string> m_history;

		private int m_historyPosition;

		private string m_input;

		private string m_output;

		private Rect m_windowRect;

		private Rect m_closeButtonRect;

		private Vector2 m_scrollPosition;

		private bool m_isFirstKeyDown;

		private void Start()
		{
		}

		private void SetVisible(bool newValue)
		{
		}

		private void OnGUI()
		{
		}

		private void DrawConsole()
		{
		}

		private Rect DefineWindowRect()
		{
			return default(Rect);
		}

		private void DrawConsoleWindow(int id)
		{
		}

		private bool IsKeyEvent(KeyCode keyCode)
		{
			return false;
		}

		private void RunLuaCommand()
		{
		}

		private string GetLuaResultString(Lua.Result result)
		{
			return null;
		}

		private string FormatTableResult(Lua.Result result)
		{
			return null;
		}

		private void UseHistory(int direction)
		{
		}
	}
}

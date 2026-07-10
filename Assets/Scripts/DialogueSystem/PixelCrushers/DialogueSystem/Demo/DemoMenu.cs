using PixelCrushers.DialogueSystem.UnityGUI;
using UnityEngine;
using UnityEngine.Events;

namespace PixelCrushers.DialogueSystem.Demo
{
	public class DemoMenu : MonoBehaviour
	{
		[TextArea]
		public string startMessage;

		public KeyCode menuKey;

		public GUISkin guiSkin;

		public bool closeWhenQuestLogOpen;

		public UnityEvent onOpen;

		public UnityEvent onClose;

		private QuestLogWindow questLogWindow;

		private bool isMenuOpen;

		private Rect windowRect;

		private ScaledRect scaledRect;

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void OnGUI()
		{
		}

		private void WindowFunction(int windowID)
		{
		}

		public void Open()
		{
		}

		public void Close()
		{
		}

		private void SetMenuStatus(bool open)
		{
		}

		private bool IsQuestLogOpen()
		{
			return false;
		}

		private void OpenQuestLog()
		{
		}

		private void SaveGame()
		{
		}

		private void LoadGame()
		{
		}

		private void ClearSavedGame()
		{
		}
	}
}

using UnityEngine;
using UnityEngine.Events;

namespace PixelCrushers
{
	public class SaveSystemTestMenu : MonoBehaviour
	{
		public string menuInputButton;

		public GUISkin guiSkin;

		public Vector2 buttonSize;

		public int saveSlot;

		public string instructions;

		public float instructionsDuration;

		public bool pauseWhileOpen;

		public bool allowCursorWhileOpen;

		public UnityEvent onShow;

		public UnityEvent onHide;

		private bool m_isVisible;

		private float m_instructionsDoneTime;

		private bool m_prevCursorState;

		private void Awake()
		{
		}

		private void Update()
		{
		}

		public void ToggleMenu()
		{
		}

		private void HandleCursor(bool open)
		{
		}

		private void OnGUI()
		{
		}
	}
}

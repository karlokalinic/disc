using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Rebind
{
	public class RebindingUI : MonoBehaviour
	{
		private const bool SHOW_ALWAYS_IN_EDITOR = false;

		[SerializeField]
		private GameObject mainWindow;

		[SerializeField]
		private RebindActionRecord actionPrefab;

		[SerializeField]
		private RebindBindingRecord bindingPrefab;

		[SerializeField]
		private Transform actionsContainer;

		[SerializeField]
		private Button refreshButton;

		[SerializeField]
		private Button disableListenButton;

		[SerializeField]
		private Button resetToDefault;

		[SerializeField]
		private CanvasGroup canvasGroup;

		private UnityEvent OnDisableListenButtonPressed;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void CheckIfMainWindowShouldBeShown()
		{
		}

		private void Update()
		{
		}

		private void RefreshKeybindUI()
		{
		}

		private void DisableKeyListen()
		{
		}

		private void MapAllPlayerActionsToUI()
		{
		}

		private void EnableButtons()
		{
		}

		private void DisableButtons()
		{
		}

		private void ClearAllChildren()
		{
		}

		public void ResetBindingsButtonPressed()
		{
		}

		public static void DebugPrint()
		{
		}

		public static void DebugInputAction()
		{
		}
	}
}

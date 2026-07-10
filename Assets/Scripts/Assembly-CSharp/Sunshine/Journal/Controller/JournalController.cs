using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Voidforge;

namespace Sunshine.Journal.Controller
{
	public class JournalController : SingletonComponent<JournalController>
	{
		public JournalTasksController tasklist;

		public GameObject tasksTab;

		public RectTransform tasksLabel;

		public Toggle tasksToggle;

		[SerializeField]
		private JournalSubtasksController subtasksController;

		public RectTransform taskDescriptionArea;

		public TextMeshProUGUI selectedTaskTitle;

		public TextMeshProUGUI selectedTaskFiledDateTime;

		public TextMeshProUGUI taskDescriptionTextField;

		public TextMeshProUGUI taskStateDescription;

		public Toggle showActiveToggle;

		public Toggle showDoneToggle;

		public TextMeshProUGUI showActiveLabel;

		public TextMeshProUGUI showDoneLabel;

		public TweenRectTransform tasksTogglesBackground;

		public GameObject profileMissing;

		public GameObject profileDiscovered;

		public GameObject checksTab;

		public GameObject map;

		public GameObject mapMissing;

		public JournalWhiteCheckUI checkTemplate;

		public WhiteCheckCoordinatesUI checkCoords;

		public RectTransform checksListContainer;

		public RectTransform checksLabel;

		public Toggle checksToggle;

		public TweenRectTransform checksTogglesBackground;

		public VerticalStepScrollView checksVerticalStep;

		[SerializeField]
		private Selectable checksRightSelectable;

		public GameObject TasksNotifyIcon;

		public GameObject MapNotifyIcon;

		public GameObject ActiveTasksNotifyIcon;

		public GameObject DoneTasksNotifyIcon;

		public List<JournalWhiteCheckUI> shownWhiteChecksList;

		public HashSet<string> WhiteChecksWithNotificationOnInit;

		private bool closeJournal;

		private bool tasksInitialized;

		public Dictionary<string, JournalWhiteCheckUI> ShownWhiteChecks { get; }

		public bool TasksInitialized
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		protected override void Awake()
		{
		}

		public void OnInputKey()
		{
		}

		public void OnJournalInputKey()
		{
		}

		public void OnMapInputKey()
		{
		}

		private void CicleActiveDone()
		{
		}

		public void ClearJournalDisplayObjects()
		{
		}

		public void Start()
		{
		}

		private void Update()
		{
		}

		public void OnEnable()
		{
		}

		public void OnDisable()
		{
		}

		private void OnLanguageChanged()
		{
		}

		private void JumpTasksBackground()
		{
		}

		private void JumpChecksBackground()
		{
		}

		private void UpdateJumpBackground(TweenRectTransform background, Transform target)
		{
		}

		private IEnumerator DelayedUpdateTweenBackgroundJump(TweenRectTransform background, RectTransform targetRect)
		{
			return null;
		}

		private void MoveTasksBackground()
		{
		}

		private void MoveChecksBackground(Transform target)
		{
		}

		private void UpdateMoveBackground(TweenRectTransform background, Transform target)
		{
		}

		private IEnumerator DelayedUpdateTweenBackgroundMove(TweenRectTransform background, RectTransform targetRect)
		{
			return null;
		}

		public void ToggleTasks()
		{
		}

		public void ToggleChecks()
		{
		}

		public void ToggleActiveTasks(bool isOn)
		{
		}

		public void ToggleDoneTasks(bool isOn)
		{
		}

		public void NotifyTaskDone()
		{
		}

		public void NotifyTaskRevealed()
		{
		}

		public void NotifySubtaskUpdated()
		{
		}

		public Selectable GetFirstCheckFromTheList()
		{
			return null;
		}

		public void Reinitialize()
		{
		}

		private void InitInterface()
		{
		}

		public void OnWhiteCheckCached(WhiteCheck whiteCheck)
		{
		}

		public void OnSeenWhiteCheckCached(WhiteCheck whiteCheck)
		{
		}

		private bool ShouldWhiteCheckHaveNotificationOnInit(WhiteCheck whiteCheck)
		{
			return false;
		}

		public void OnTabsToggleValueChanged()
		{
		}

		public void OnSwitchedToView()
		{
		}

		private void DrawJournal()
		{
		}

		private void DrawTasks()
		{
		}

		private void DrawChecks()
		{
		}

		public void EnableCheckCoordinatesForTesting()
		{
		}

		public void UpdateShownWhiteChecks()
		{
		}

		private void UpdateChecksNavigation()
		{
		}

		public void RefreshShownWhiteChecks()
		{
		}

		private void PositionObject(Transform transform, int index)
		{
		}

		public void DisplayTaskDetails(Completeable task)
		{
		}

		public void DisplayCheckCoords(JournalWhiteCheckUI checkUI)
		{
		}

		public void ClearTaskDetailsIfNecessary()
		{
		}

		public void HideDescription()
		{
		}

		public void DebugPrintTasks()
		{
		}

		public static void ImportFromArticy()
		{
		}

		public void ManuallyUpdateToggles(bool showTasks)
		{
		}

		private void ShowTasksTab()
		{
		}

		private void HideTasksTab()
		{
		}

		private void ShowChecksTab()
		{
		}

		private void HideChecksTab()
		{
		}

		private bool CheckIsInDictionary(WhiteCheck whiteCheck)
		{
			return false;
		}

		public void RegisterEvents()
		{
		}

		public void UnregisterEvents()
		{
		}
	}
}

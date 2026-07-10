using System;
using System.Collections;
using System.Collections.Generic;
using Sunshine.Metric;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Sunshine
{
	public class AllThoughtsList : MonoBehaviour
	{
		[SerializeField]
		private Selectable upSelectable;

		[SerializeField]
		private Selectable downSelectable;

		[SerializeField]
		private Selectable leftSelectable;

		[SerializeField]
		private Selectable rightSelectable;

		[SerializeField]
		private ThoughtOnList _template;

		[SerializeField]
		private SelectionNavigationGroup _viewportNavigation;

		[SerializeField]
		private RectTransform _contentParent;

		[SerializeField]
		private ThoughtState[] _statusSortPriorities;

		[SerializeField]
		private TweenRectTransform sortTypeBackground;

		[SerializeField]
		private Transform gainedUnknownSeparator;

		[SerializeField]
		private Transform unknownForgottenSeparator;

		[Space]
		[SerializeField]
		private Button buttonSortByStatus;

		[SerializeField]
		private Image imageSortByStatus;

		[SerializeField]
		private TextMeshProUGUI textSortByType;

		[Space]
		[SerializeField]
		private Button buttonSortByDate;

		[SerializeField]
		private Image imageSortByDate;

		[SerializeField]
		private TextMeshProUGUI textSortByDate;

		[Space]
		[SerializeField]
		private Button buttonSortAZ;

		[SerializeField]
		private Image imageSortAZ;

		[SerializeField]
		private TextMeshProUGUI textSortAZ;

		private ThoughtsSortType currentSortType;

		private List<ThoughtOnList> thoughtListElements;

		private List<ThoughtOnList> gatheredThoughts;

		private List<ThoughtOnList> unknownThoughts;

		private List<ThoughtOnList> forgottenThoughts;

		private RectTransform targetRectSortStatus;

		private RectTransform targetRectSortDate;

		private RectTransform targetRectAZ;

		public Action<ThoughtCabinetProject> OnThoughtSelected;

		public VerticalStepScrollView verticalStep;

		public bool AreUnknownSeen => false;

		public bool AreUnknownForgottenSeen => false;

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Update()
		{
		}

		public void Initialize()
		{
		}

		private void ConnectEvents()
		{
		}

		private void DisconnedEvents()
		{
		}

		public void ConnectSelectionEvents()
		{
		}

		private void OnLanguageChanged()
		{
		}

		private IEnumerator DelayedUpdateTabsRects()
		{
			return null;
		}

		public void RefreshList(bool setDefaultSorting)
		{
		}

		public bool HasBreakthroughThoughts()
		{
			return false;
		}

		public void OnThoughtCabinetClose()
		{
		}

		public bool RefreshElement(ThoughtCabinetProject project)
		{
			return false;
		}

		public bool UpdateElement(ThoughtCabinetProject project)
		{
			return false;
		}

		public bool RemoveElement(ThoughtCabinetProject project)
		{
			return false;
		}

		public void AddElement(ThoughtCabinetProject project)
		{
		}

		public Selectable GetFirstFromList()
		{
			return null;
		}

		private void SelectElement(ThoughtCabinetProject project, bool fromList)
		{
		}

		private void DeselectElement(ThoughtCabinetProject project)
		{
		}

		private ThoughtOnList InstantiateNewElement()
		{
			return null;
		}

		public ThoughtOnList GetElementWithProject(ThoughtCabinetProject project)
		{
			return null;
		}

		private void SetDefaultSorting()
		{
		}

		private void SortList(ThoughtsSortType sortType)
		{
		}

		private void ResetSortTabsUI()
		{
		}

		private void UpdateSecondaryThoughtsLists()
		{
		}

		private void SetStatusSorting()
		{
		}

		public ThoughtCabinetProject GetThoughtProjectWithName(string projectDisplayName)
		{
			return null;
		}

		private void HandleStatusTabUI()
		{
		}

		private void SetDateSorting()
		{
		}

		private void HandleDateTabUI()
		{
		}

		private void SetAZSorting()
		{
		}

		private void HandleAZTabUI()
		{
		}

		private List<ThoughtOnList> GetStatusSortedThoughts(List<ThoughtOnList> thoughts)
		{
			return null;
		}

		private List<ThoughtOnList> GetSortedCookingThoughts(List<ThoughtOnList> thoughts)
		{
			return null;
		}

		private List<ThoughtOnList> GetGatheredThoughts(List<ThoughtOnList> thoughts)
		{
			return null;
		}

		private List<ThoughtOnList> GetSortedGatheredThoughts(List<ThoughtOnList> thoughts)
		{
			return null;
		}

		private List<ThoughtOnList> GetUnknownThoughts(List<ThoughtOnList> thoughts)
		{
			return null;
		}

		private List<ThoughtOnList> GetForgottenThoughts(List<ThoughtOnList> thoughts)
		{
			return null;
		}

		public void SelectDefault()
		{
		}
	}
}

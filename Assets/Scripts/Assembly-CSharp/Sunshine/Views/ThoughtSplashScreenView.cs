using Sunshine.Feld;
using Sunshine.Metric;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Playables;
using UnityEngine.UI;

namespace Sunshine.Views
{
	public class ThoughtSplashScreenView : View
	{
		[SerializeField]
		private SplashScreenTabController tabController;

		[SerializeField]
		private ScrollRect scrollRect;

		[SerializeField]
		private Image image;

		[SerializeField]
		private Button buttonClose;

		[SerializeField]
		private TextMeshProUGUI titleText;

		[SerializeField]
		private TextMeshProUGUI propertiesText;

		[SerializeField]
		private TextMeshProUGUI completionDescriptionText;

		[Space]
		private PlayableDirector pd;

		private ThoughtCabinetProject currentProject;

		private string thoughtsIconsPath;

		public override void Awake()
		{
		}

		private void ResetRectTransformPos()
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

		public override FeldView GetFeldViewType()
		{
			return default(FeldView);
		}

		public override ViewType GetViewType()
		{
			return default(ViewType);
		}

		public override bool CanTransitionFromCurrentView()
		{
			return false;
		}

		public override void InitTransforms()
		{
		}

		public override void SwitchToView(ViewType previousView)
		{
		}

		public override void OnExitView(ViewType nextView)
		{
		}

		public void ToggleView()
		{
		}

		private void DisplayThought()
		{
		}

		private void SetThoughtProject(ThoughtCabinetProject project)
		{
		}

		private void ResetScrollBarPositionToTop()
		{
		}

		public void RequestTitleVO()
		{
		}

		public void RequestDescritpionVO()
		{
		}

		private bool CheckIfAddressableExist(string path)
		{
			return false;
		}

		private void SetOnExitButton(UnityAction action)
		{
		}

		public override void SetInitialSelect()
		{
		}

		private void OnLeftTabPressed()
		{
		}

		private void OnRightTabPressed()
		{
		}

		private void OnControllerButtonToClosePressed()
		{
		}
	}
}

using UnityEngine;
using UnityEngine.UI;

namespace CollageMode
{
	public class CollageDialogueContinueButton : MonoBehaviour
	{
		[SerializeField]
		private MultipleToggle continueButtonToggle;

		[SerializeField]
		private Image image;

		[SerializeField]
		private string[] continueButtonTerms;

		private int continueButtonIndex;

		public int ContinueButtonIndex => 0;

		private void OnEnable()
		{
		}

		public void SetContinueButtonIndex(int continueButtonIndex)
		{
		}

		public void SetNextContinueButtonIndex()
		{
		}

		private void OnContinueButtonToggleValueChanged()
		{
		}

		private void RefreshImage()
		{
		}
	}
}

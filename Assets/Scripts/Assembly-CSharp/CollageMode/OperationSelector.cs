using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace CollageMode
{
	public class OperationSelector : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
	{
		[SerializeField]
		private OperationsSet operationsSet;

		[SerializeField]
		private Button previousButton;

		[SerializeField]
		private Button nextButton;

		[SerializeField]
		private Image previewImage;

		[SerializeField]
		private TextMeshProUGUI previewText;

		private int selectedIndex;

		private void Start()
		{
		}

		private void OnPreviousClicked()
		{
		}

		private void OnNextClicked()
		{
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		public void OnPointerClick(PointerEventData eventData)
		{
		}

		private void Refresh()
		{
		}

		private void Select(int index, bool execute = true)
		{
		}
	}
}

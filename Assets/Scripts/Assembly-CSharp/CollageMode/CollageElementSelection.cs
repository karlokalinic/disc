using UnityEngine;

namespace CollageMode
{
	public class CollageElementSelection : MonoBehaviour
	{
		[SerializeField]
		private float angleLimit;

		[SerializeField]
		private float selectionVectorThreshold;

		[SerializeField]
		private float selectionVectorHysteresis;

		private CollageElement selectedBeforeScreenshot;

		private CollageElement lastSelected;

		private SelectionMode selectionModeBeforeScreenshot;

		private bool selectionPerformed;

		private void Awake()
		{
		}

		private void Update()
		{
		}

		private void SelectInDirection(Vector2 direction)
		{
		}

		private void OnBeforeScreenshot()
		{
		}

		private void OnAfterScreenshot()
		{
		}
	}
}

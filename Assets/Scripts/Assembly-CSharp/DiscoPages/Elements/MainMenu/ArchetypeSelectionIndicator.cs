using System.Collections;
using UnityEngine;

namespace DiscoPages.Elements.MainMenu
{
	public class ArchetypeSelectionIndicator : MonoBehaviour
	{
		[SerializeField]
		private GameObject otherIndicatorPrefab;

		[SerializeField]
		private GameObject selectedIndicator;

		[SerializeField]
		private float spacing;

		[Space]
		[SerializeField]
		private float transitionDuration;

		private RectTransform[] indicatorsTransforms;

		private float iconSize;

		private float leftmostPos;

		private int currentlySelected;

		public void Initialize(int indicatorsCount)
		{
		}

		private IEnumerator AlignIndicators(int indicatorsCount)
		{
			return null;
		}

		public void MoveUp()
		{
		}

		public void MoveDown()
		{
		}

		private void MoveIndicator(RectTransform indicator, int endPos)
		{
		}
	}
}

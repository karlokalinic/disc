using System.Collections.Generic;
using Pages.MainMenu.Charsheet;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace DiscoPages.Elements.MainMenu
{
	public class PageSystemAbilityPointsSet : MonoBehaviour
	{
		[SerializeField]
		private TMP_Text backgroundPoints;

		[SerializeField]
		private Transform pipsParent;

		[SerializeField]
		private Button buttonIncrease;

		[SerializeField]
		private Button buttonDecrease;

		private CustomStatsPage page;

		private int maxPoints;

		private int currentPoints;

		private List<AnimatedSegment> pips;

		public void Initialize(CustomStatsPage page, int initialPoints)
		{
		}

		public void SetPoints(int points)
		{
		}

		private void Increase()
		{
		}

		private void Decrease()
		{
		}

		private void GetPips()
		{
		}
	}
}

using System;
using Sunshine.Metric;
using UnityEngine;
using UnityEngine.UI;

namespace Charsheet
{
	public class SkillPortrayConfigurator : MonoBehaviour
	{
		[Serializable]
		public struct OutsideColumnNavigationReferences
		{
			public CharSheetMode mode;

			public Selectable[] left;

			public Selectable[] right;

			public Selectable[] down;

			public Selectable GetLeft(int i)
			{
				return null;
			}

			public Selectable GetRight(int i)
			{
				return null;
			}

			public Selectable GetDown(int i)
			{
				return null;
			}

			private static Selectable GetSelectable(Selectable[] table, int i)
			{
				return null;
			}
		}

		[SerializeField]
		private SkillPortraitPanel prefab;

		[SerializeField]
		private Transform parent;

		[SerializeField]
		private SkillPortraitPanel[] skillList;

		[SerializeField]
		private OutsideColumnNavigationReferences[] navigationReferences;

		private int numberOfColumns;

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private OutsideColumnNavigationReferences GetNavigationReference(CharSheetMode newMode)
		{
			return default(OutsideColumnNavigationReferences);
		}

		private void UpdateNavigation(CharSheetMode newMode)
		{
		}

		private void UpdateSkillPortraitPanelsContent()
		{
		}

		private void Spawn()
		{
		}

		private bool IsExcluded(SkillType skillType)
		{
			return false;
		}

		public Selectable GetFirstSkillButton()
		{
			return null;
		}
	}
}

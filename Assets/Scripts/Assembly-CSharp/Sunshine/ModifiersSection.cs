using System.Collections.Generic;
using Sunshine.Metric;
using Sunshine.Views;
using UnityEngine;

namespace Sunshine
{
	public class ModifiersSection : MonoBehaviour
	{
		private bool initialized;

		[SerializeField]
		private AbilityType abilityType;

		[SerializeField]
		private RectTransform colorCodeRect;

		[SerializeField]
		private RectTransform colorCodeRectRTL;

		[SerializeField]
		private Transform modifiersParent;

		[SerializeField]
		private SkillModifierTemplate templateSkillModifier;

		private List<SkillModifierTemplate> modifiers;

		private void Awake()
		{
		}

		public void Refresh(ViewType currentView)
		{
		}

		private void Initialize(ViewType currentView)
		{
		}
	}
}

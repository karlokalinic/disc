using System;
using System.Collections.Generic;

namespace Sunshine.Metric
{
	public class CharacterThoughts
	{
		public static Action OnThoughtCabinetChanged;

		public HashSet<ThoughtCabinetProject> gainedThoughts;

		public HashSet<ThoughtCabinetProject> forgottenThoughts;

		public List<ThoughtCabinetProject> discoveredThoughts;

		public Dictionary<ThoughtCabinetProject, CharacterEffect[]> cookingEffects;

		public Dictionary<ThoughtCabinetProject, CharacterEffect[]> fixedEffects;

		private readonly CharacterSheet characterSheet;

		private int _freshCount;

		public int FreshCount
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public void ClearAll()
		{
		}

		public CharacterThoughts(CharacterSheet characterSheet)
		{
		}

		private void Initialize()
		{
		}

		public void ClearCookingThoughts(ModifierType modifierType)
		{
		}

		public bool ThoughtGained(ThoughtCabinetProject project)
		{
			return false;
		}

		public bool ThoughtCooking(ThoughtCabinetProject project)
		{
			return false;
		}

		public bool ThoughtFixed(ThoughtCabinetProject project)
		{
			return false;
		}

		public bool ThoughtForgotten(ThoughtCabinetProject project)
		{
			return false;
		}

		public void GainThought(ThoughtCabinetProject project)
		{
		}

		public void RegisterThought(ThoughtCabinetProject project)
		{
		}

		public bool UnregisterFixedThought(ThoughtCabinetProject project)
		{
			return false;
		}

		public bool UnregisterCookingThought(ThoughtCabinetProject project)
		{
			return false;
		}

		public bool UnregisterDiscoveredThought(ThoughtCabinetProject project)
		{
			return false;
		}

		public void DiscoverThought(ThoughtCabinetProject project)
		{
		}

		public void FixThought(ThoughtCabinetProject project)
		{
		}

		public void ForgetThought(ThoughtCabinetProject thought)
		{
		}

		public static void FireTHCOnChangeEvent()
		{
		}

		public static bool IsThoughtCooking(string thought)
		{
			return false;
		}

		public static bool IsThoughtFixed(string thought)
		{
			return false;
		}
	}
}

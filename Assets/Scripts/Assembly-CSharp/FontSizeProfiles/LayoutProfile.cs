using System.Collections.Generic;
using FontSizeProfiles.BuildParts;
using FontSizeProfiles.ViewProfiles;
using UnityEngine;

namespace FontSizeProfiles
{
	[CreateAssetMenu]
	public class LayoutProfile : ScriptableObject
	{
		public string proflieName;

		public MainMenuProfile mainMenuProfile;

		public OptionsProfile optionsProfile;

		public ControllerHelpMenuProfile controllerHelpMenuProfile;

		public InfoPanelProfile infoPanelProfile;

		public SaveLoadProfile saveLoadProfile;

		public ArchetypeSelectionProfile archetypeSelectionProfile;

		public CharsheetProfile charsheetProfile;

		public InventoryProfile inventoryProfile;

		public LeftStatsHealthBonusesPanelProfile leftStatsHealthBonusesPanelProfile;

		public ThoughtCabinetProfile thoughtCabinetProfile;

		public ThoughtSplashScreenProfile thoughtSplashScreenProfile;

		public JournalProfile journalProfile;

		public MapProfile mapProfile;

		public NewspaperEndingProfile newspaperEndingProfile;

		public CollageModeProfile collageModeProfile;

		public Dictionary<string, ElementSettings> GetAllTextElements()
		{
			return null;
		}

		private string ToJSON()
		{
			return null;
		}
	}
}

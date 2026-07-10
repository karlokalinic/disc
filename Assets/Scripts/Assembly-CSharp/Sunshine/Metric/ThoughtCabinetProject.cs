using LocalizationCustomSystem;
using UnityEngine;

namespace Sunshine.Metric
{
	public class ThoughtCabinetProject : MonoBehaviour, IModifierCause
	{
		private const string VO_PATH = "Assets/Sounds/Dialogue/ThoughtsCompletion/";

		private const string VO_DESCRIPTION_TERM = "_DESCRIPTION";

		private const string VO_TITLE_TERM = "_TITLE";

		private const string VO_EXTENSION = ".wav";

		public bool fresh;

		[SerializeField]
		private int researchTimeLeft;

		[SerializeField]
		private int researchTime;

		public CharacterEffect[] researchEffects;

		public CharacterEffect[] completionEffects;

		public SunshineClockTime discoverTime;

		[SerializeField]
		private string voiceoverTerm;

		public TranslationString displayNameTerm;

		public TranslationString descriptionTerm;

		public TranslationString completionDescriptionTerm;

		private ThoughtState _state;

		public ThoughtState state
		{
			get
			{
				return default(ThoughtState);
			}
			set
			{
			}
		}

		public int ResearchTimeLeft
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int ResearchTime
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public float ResearchProgress => 0f;

		public string VoiceoverDescriptionPath => null;

		public string VoiceoverTitlePath => null;

		public string VoiceoverTerm => null;

		public string displayName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string displayNameToUpper
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string formattedDisplayNameUpper
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string description
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string completionDescription
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private void Awake()
		{
		}

		public void RestoreToNormal()
		{
		}

		public string GetDisplayName()
		{
			return null;
		}

		public int CompareTo(ThoughtCabinetProject other)
		{
			return 0;
		}

		public void SetStateFromPersistence(ThoughtState savedState)
		{
		}

		private bool IsSplitCharacter(char ch)
		{
			return false;
		}
	}
}

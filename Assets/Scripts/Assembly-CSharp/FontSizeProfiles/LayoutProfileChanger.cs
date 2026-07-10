using System.Collections.Generic;
using FontSizeProfiles.BuildParts;
using UnityEngine;
using UnityEngine.Events;

namespace FontSizeProfiles
{
	public class LayoutProfileChanger : LiteSingleton<LayoutProfileChanger>
	{
		[SerializeField]
		private List<LayoutProfile> profiles;

		[SerializeField]
		private LayoutProfile currentlySelectedProfile;

		public static UnityEvent OnLayoutChanged;

		private Dictionary<string, ElementSettings> textElementsDictionary;

		protected override void Awake()
		{
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		public static TextElementSettings GetTextElement(string textID)
		{
			return null;
		}

		public static AutoTextElementSettings GetAutoTextElement(string textID)
		{
			return null;
		}

		public static RectElementSettings GetRectElement(string textID)
		{
			return null;
		}

		public static RectElementHorizontalSettings GetRectSimplifiedElement(string textID)
		{
			return null;
		}

		public static RectElementHeightSettings GetRectHeightSettings(string ID)
		{
			return null;
		}

		public static MonoBehaviourEnableSettings GetMonoBehaviourEnableSettings(string id)
		{
			return null;
		}

		private void LoadInitialProfile()
		{
		}

		public bool LoadProfile(int id)
		{
			return false;
		}

		private void LoadProfile(LayoutProfile profile)
		{
		}

		private void DEBUG_GetNextProfile()
		{
		}
	}
}

using System.Collections.Generic;
using FortressOccident;
using UnityEngine;
using Voidforge;

namespace Sunshine.Hack
{
	public class Kubujuss : SingletonComponent<Kubujuss>
	{
		public Dictionary<string, Transform> cachedItemsTransforms;

		private List<CutsceneObjectSaver> cutsceneObjects;

		protected ComponentRef<Character> _character;

		public static Character character => null;

		public static List<CutsceneObjectSaver> CutsceneObjectSavers => null;

		protected override void Awake()
		{
		}

		public static void AddCutsceneObjectSaver(CutsceneObjectSaver cutsceneObjectSaver)
		{
		}

		public static void RemoveCutsceneObjectSaver(CutsceneObjectSaver cutsceneObjectSaver)
		{
		}
	}
}

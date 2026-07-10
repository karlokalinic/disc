using System.Collections;
using UnityEngine;

namespace Sunshine
{
	public abstract class CutsceneSituation : MonoBehaviour
	{
		protected static readonly int sitOnBedIdle;

		protected static readonly int getUpFromBed;

		private bool started;

		public static bool CUTSCENE_SITUATION_ACTIVE;

		public static bool IgnoreEnvironmentalMusic;

		public virtual void Awake()
		{
		}

		public virtual void OnEnable()
		{
		}

		public virtual void OnDisable()
		{
		}

		public virtual void OnInterruption()
		{
		}

		public abstract IEnumerator PerformActions();

		public static void RegisterEscapeKeyListener()
		{
		}

		public static void UnregisterEscapeKeyListener()
		{
		}

		private static void IgnoreInput()
		{
		}
	}
}

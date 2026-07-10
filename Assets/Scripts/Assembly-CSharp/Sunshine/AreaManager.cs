using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Voidforge;

namespace Sunshine
{
	public class AreaManager : VoidElement
	{
		public const string WHIRLING_INT_F2 = "Whirling-int-f2";

		public const string WHIRLING_INT_F1 = "Whirling-int-f1";

		public const string MARTINAISE_EXT = "Martinaise-ext";

		public const string CORPSE_YARD = "Dream-2";

		public const string ISLAND = "Sea-fortress-int";

		public const string SHACK = "Second-home-int";

		public const string INSTIGATORS_LAIR_INT = "Instigators-lair-int";

		public const string DREAM_3_INT = "Dream-3-int";

		public List<string> additivelyLoadedScenes;

		[SerializeField]
		protected AnimationCurve _cameraZoomCurve;

		[SerializeField]
		protected bool _hideCursorWhileLoading;

		[SerializeField]
		protected bool _isOutsideArea;

		[SerializeField]
		protected bool loadOnStart;

		protected int _loadedScenesCount;

		public UnityEvent onLoadingComplete;

		private IEnumerator loadCoR;

		public static AreaManager current { get; protected set; }

		public static AnimationCurve cameraZoomCurve => null;

		public static bool isReady => false;

		protected void Start()
		{
		}

		public void LoadAreas()
		{
		}

		private IEnumerator LoadAreasCoR()
		{
			return null;
		}

		protected void OnDestroy()
		{
		}
	}
}

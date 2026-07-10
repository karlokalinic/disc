using UnityEngine;
using Voidforge;

namespace FortressOccident
{
	public class DialogueImage : SingletonComponent<DialogueImage>
	{
		public const string DARKNESS = "darkness";

		public const string WHITENESS = "whitenes";

		public const string FURIES = "furies";

		public const string LOBBY_BACKDROP = "lobby_backdrop";

		public const string TEQUILA_FACE = "tequila_face";

		public const string DISCO_ELYSIUM = "disco_elysium";

		public const string DISCO_ELYSIUM_CLEAN = "disco_elysium_clean";

		private Camera cam;

		public LayerElement imageLayerTemplate;

		public LayerElement localizedImageLayerTemplate;

		public Transform overlayHolder;

		public AnimationCurve appearCurve;

		public AnimationCurve disappearCurve;

		public AnimationCurve hangedmanAppearCurve;

		public Material spriteMaterial;

		public Material translationSpriteMaterial;

		public Material flashMaterial;

		public AnimationCurve flashDisappearCurve;

		public float flashDuration;

		public void Flash(string imageName)
		{
		}

		public void Start()
		{
		}

		public void InstantShow(string imageName)
		{
		}

		public LayerElement Show(string imageName, AnimationCurve customAppearCurve = null, bool flash = false)
		{
			return null;
		}

		public LayerElement ShowLocalized(string imageName, string imageLocalizationTerm, AnimationCurve customAppearCurve = null, bool flash = false)
		{
			return null;
		}

		public void Hide(string imageName)
		{
		}

		public void Hide(string imageName, AnimationCurve customDisappearCurve = null)
		{
		}

		public void Hide()
		{
		}

		private void FitToScreen(LayerElement element)
		{
		}

		public void TestDarkness()
		{
		}

		public void TestTeqiula()
		{
		}

		public void TestWhiteness()
		{
		}

		public void TestFlash()
		{
		}

		public void TestHide()
		{
		}
	}
}

using FortressOccident;
using UnityEngine;

namespace Sunshine
{
	public abstract class CharacterItem : FOComponent, IVitruvianHandler
	{
		protected static readonly string vitruvianTexturePropertyName;

		protected static readonly string transparencyTexturePropertyName;

		[SerializeField]
		protected string itemId;

		[SerializeField]
		protected VitruvianLayer layer;

		[SerializeField]
		protected Texture2D vitruvianTexture;

		protected Character _wearer;

		protected Texture2D transparencyTexture;

		public VitruvianManager vitruvian => null;

		public int vitruvianLayerIndex => 0;

		public virtual Character wearer
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Color32[] GetVitruvianMap(int size)
		{
			return null;
		}

		public void SetProperties(Color32[] transparencyMap, int size, bool outlinesOverride, bool noShadow)
		{
		}

		protected override void Awake()
		{
		}

		protected virtual void OnDestroy()
		{
		}
	}
}

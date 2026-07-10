using System.Collections.Generic;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	public class PreloadActorPortraits : MonoBehaviour
	{
		public bool supportUnityUI;

		public bool collapseLegacyTextures;

		private List<Texture2D> legacyPortraits;

		private void Start()
		{
		}

		public void PreloadActor(Actor actor)
		{
		}

		public Texture2D PreloadTexture(Texture2D texture)
		{
			return null;
		}
	}
}

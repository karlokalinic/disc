using System;
using UnityEngine;

namespace PixelCrushers.DialogueSystem.UnityGUI
{
	[Serializable]
	public class ImageAnimation
	{
		public bool animate;

		public int frameWidth;

		public float framesPerSecond;

		private int numFrames;

		private float frameNormalWidth;

		private int currentFrame;

		private float nextFrameTime;

		private Rect texCoords;

		private float lastDialogueTime;

		public void RefreshAnimation(Texture2D image)
		{
		}

		public void DrawAnimation(Rect rect, Texture2D image)
		{
		}
	}
}

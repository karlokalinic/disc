using System;
using UnityEngine;
using UnityEngine.Events;

namespace FortressOccident
{
	[Serializable]
	public struct FXSettings
	{
		public string name;

		public AnimationCurve animation;

		public Color colorOfFade;

		public Color colorOfPain;

		public bool isToggled;

		public float time;

		public AnimatedVariable fisheye;

		public AnimatedVariable noise;

		public AnimatedVariable fade;

		public AnimatedVariable pain;

		public AnimatedVariable heartbeats;

		public Texture2D mask;

		public UnityEvent callEvent;

		public bool fadeIsAdditive;

		public bool isActive;
	}
}

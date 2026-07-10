using System;
using Sunshine.Metric;
using UnityEngine;

namespace Charsheet
{
	[Serializable]
	public struct SkillPortraitLabelSettings
	{
		public SkillType skill;

		[TextArea]
		public string labelText;

		public float fontSize;

		public float leftMargin;

		public float lineSpace;

		public Vector2 textOffset;

		public Vector2 labelOffset;

		public Vector2 nameplateSize;
	}
}

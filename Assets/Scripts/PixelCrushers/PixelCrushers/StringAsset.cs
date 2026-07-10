using UnityEngine;

namespace PixelCrushers
{
	public class StringAsset : ScriptableObject
	{
		[TextArea]
		[SerializeField]
		private string m_text;

		public string text
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override string ToString()
		{
			return null;
		}
	}
}

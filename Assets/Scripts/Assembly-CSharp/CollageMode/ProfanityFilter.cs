using System;
using System.Collections.Generic;
using UnityEngine;

namespace CollageMode
{
	public class ProfanityFilter : LiteSingleton<ProfanityFilter>
	{
		[SerializeField]
		private TextAsset[] swearWordsTextAssets;

		private List<string> swearWords;

		protected override void Awake()
		{
		}

		public void Filter(string text, Action<string> onComplete)
		{
		}

		private string Filter(string text)
		{
			return null;
		}

		private string FilterWord(string word)
		{
			return null;
		}
	}
}

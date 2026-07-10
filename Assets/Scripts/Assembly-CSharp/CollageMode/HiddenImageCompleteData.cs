using UnityEngine;

namespace CollageMode
{
	[CreateAssetMenu]
	public class HiddenImageCompleteData : ScriptableObject
	{
		private const string TermPrefix = "HIDDEN/";

		public Sprite fullImage;

		public string VOPath;

		public string achivementToUnlock;

		[SerializeField]
		private string term;

		public string Term => null;

		public string ShortTerm => null;
	}
}

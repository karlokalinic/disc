using UnityEngine;

namespace CollageMode
{
	public abstract class Operation : ScriptableObject
	{
		[SerializeField]
		protected Sprite previewSprite;

		[SerializeField]
		protected Color color;

		public virtual string DisplayTerm => null;

		public virtual string DisplayName => null;

		public virtual string DebugName => null;

		public virtual string AutofillString => null;

		public virtual Color AutofillColor => default(Color);

		public virtual bool CanBeShown => false;

		public virtual int SortingIndex => 0;

		public abstract string Identifier { get; }

		public int IndexInSet { get; set; }

		public Sprite PreviewSprite => null;

		public Color Color => default(Color);

		public bool IsFavoruite { get; set; }

		public abstract void Execute();

		public virtual void Preview()
		{
		}

		public virtual bool IsInUse()
		{
			return false;
		}

		protected string SpecialCharacterTranslation(string term)
		{
			return null;
		}
	}
}

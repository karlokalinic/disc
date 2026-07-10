using UnityEngine;

namespace PixelCrushers
{
	public class SpawnedObject : Saver
	{
		public enum Mode
		{
			OnDisable = 0,
			OnDestroy = 1
		}

		[SerializeField]
		private Mode m_mode;

		private bool m_ignoreOnDestroy;

		public Mode mode
		{
			get
			{
				return default(Mode);
			}
			set
			{
			}
		}

		public override void Start()
		{
		}

		public override void OnBeforeSceneChange()
		{
		}

		public override void OnDisable()
		{
		}

		public override void OnDestroy()
		{
		}

		protected virtual void RecordDestruction()
		{
		}

		public override string RecordData()
		{
			return null;
		}

		public override void ApplyData(string data)
		{
		}
	}
}

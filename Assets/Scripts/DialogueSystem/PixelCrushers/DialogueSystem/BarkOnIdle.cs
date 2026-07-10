using System.Collections;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	public class BarkOnIdle : BarkStarter
	{
		public float minSeconds;

		public float maxSeconds;

		public Transform target;

		private bool started;

		protected override bool useOnce => false;

		protected override void Start()
		{
		}

		protected override void OnEnable()
		{
		}

		public void StartBarkLoop()
		{
		}

		private IEnumerator BarkLoop()
		{
			return null;
		}
	}
}

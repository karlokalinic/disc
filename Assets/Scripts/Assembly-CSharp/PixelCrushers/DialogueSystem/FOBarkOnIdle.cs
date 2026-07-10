using System.Collections;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	public class FOBarkOnIdle : BarkStarter
	{
		public float minSeconds;

		public float maxSeconds;

		public Transform target;

		private bool started;

		private Transform m_transform;

		protected override void Awake()
		{
		}

		protected override void Start()
		{
		}

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
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

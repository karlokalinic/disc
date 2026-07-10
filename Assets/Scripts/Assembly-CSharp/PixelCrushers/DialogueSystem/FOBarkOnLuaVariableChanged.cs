using System.Collections;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	public class FOBarkOnLuaVariableChanged : BarkStarter
	{
		public float minSeconds;

		public float maxSeconds;

		public Transform target;

		private bool started;

		protected override void Start()
		{
		}

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		public void StartBarkLoop(string changedVariableName)
		{
		}

		private IEnumerator BarkLoop(string changedVariableName)
		{
			return null;
		}
	}
}

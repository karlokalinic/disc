using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Voidforge
{
	public class InstancePoolTester : VoidElement
	{
		[SerializeField]
		protected int count;

		protected Text[] texts;

		protected IEnumerator CreateTextsCoR()
		{
			return null;
		}

		protected void OnEnable()
		{
		}

		private void OnDisable()
		{
		}
	}
}

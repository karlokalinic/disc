using System.Collections;
using UnityEngine;

namespace AmplifyTexture
{
	internal class PrePassReadback : MonoBehaviour
	{
		private PrePass m_prePass;

		private float m_savedShadowDistance;

		public void Initialize(PrePass prePass)
		{
		}

		private IEnumerator Start()
		{
			return null;
		}

		private IEnumerator IssuePluginEventAtEndOfFrames()
		{
			return null;
		}

		private void OnPreRender()
		{
		}

		private void OnPostRender()
		{
		}
	}
}

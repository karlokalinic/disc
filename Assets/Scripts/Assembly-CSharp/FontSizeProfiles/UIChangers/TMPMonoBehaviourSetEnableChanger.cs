using UnityEngine;

namespace FontSizeProfiles.UIChangers
{
	public class TMPMonoBehaviourSetEnableChanger : TMPChanger
	{
		[SerializeField]
		private MonoBehaviour component;

		private void Awake()
		{
		}

		protected override void OnLayoutChanged()
		{
		}
	}
}

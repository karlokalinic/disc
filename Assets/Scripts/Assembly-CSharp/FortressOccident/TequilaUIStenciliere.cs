using UnityEngine;

namespace FortressOccident
{
	public class TequilaUIStenciliere : MonoBehaviour
	{
		public Material prepassMaterial;

		private static Renderer[] renderers;

		[SerializeField]
		public bool colorOverride;

		[SerializeField]
		public Color colorCustom;

		public static TequilaUIStenciliere instance;

		private static bool lastTo;

		private static IsOnTequila lastOverrideZ;

		private void Awake()
		{
		}

		private void Update()
		{
		}

		public static void Engage(bool to, IsOnTequila overrideZ = IsOnTequila.INVENTORYVIEW)
		{
		}

		private void refr()
		{
		}

		public static void Refresh()
		{
		}

		private void On()
		{
		}

		private void OnWithoutZ()
		{
		}

		private void Off()
		{
		}
	}
}

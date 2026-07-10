using UnityEngine;

namespace Voidforge
{
	[ExecuteInEditMode]
	public class MaterialKeeperTag : InstanceKeeperTag<Material>
	{
		protected Material[] _originalMaterials;

		protected ComponentRef<Renderer> _renderer { get; set; }

		public Material material
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Material[] materials
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Material originalMaterial => null;

		public Material[] originalMaterials
		{
			get
			{
				return null;
			}
			protected set
			{
			}
		}

		protected override void Awake()
		{
		}

		protected override void OnDestroy()
		{
		}
	}
}

using UnityEngine;
using Voidforge;

public class MeshKeeperTag : InstanceKeeperTag<Mesh>
{
	[SerializeField]
	protected Mesh meshInstance;

	protected ComponentRef<MeshFilter> meshFilter { get; set; }

	protected ComponentRef<SkinnedMeshRenderer> skinnedMeshRenderer { get; set; }

	public Mesh mesh
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Mesh originalMesh { get; protected set; }

	protected override void Awake()
	{
	}

	protected override void OnDestroy()
	{
	}
}

using UnityEngine;

public class HangedManMaterialAreaPersister : MonoBehaviour
{
	private const string shootMaterialCheckName = "yard.hanged_coordination_hit_buckle";

	private const string failedVarSuffix = "_failed";

	[SerializeField]
	private Renderer hangedManRenderer;

	[SerializeField]
	private Renderer shootHangedManRenderer;

	private void OnEnable()
	{
	}

	private void SwapToShootMaterial()
	{
	}
}

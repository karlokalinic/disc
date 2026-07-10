using UnityEngine;

public abstract class PFX : MonoBehaviour
{
	public string fxName;

	public abstract void Trigger();

	public abstract void ResetPFX();

	public abstract void UpdateFX();
}

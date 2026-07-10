using UnityEngine;

public class FlashlightBehaviour : ItemBehaviour
{
	public static Light _light;

	private Light[] lights;

	public SunshineAimIK leftHandIK;

	public SunshineAimIK rightHandIK;

	private bool leftHandIKsurpressed;

	private bool rightHandIKsurpressed;

	protected override void OnEnable()
	{
	}

	private void EnableLights(bool setEnable)
	{
	}

	public override void OnIdleAnimStarted()
	{
	}

	public override void OnIdleAnimFinished()
	{
	}

	public override void OnEquipRight()
	{
	}

	public override void OnUnequipRight()
	{
	}

	public override void OnEquipLeft()
	{
	}

	public override void OnUnequipLeft()
	{
	}

	public void stopIK()
	{
	}

	public void startIK()
	{
	}
}

using UnityEngine;

public class ItemBehaviour : MonoBehaviour
{
	[SerializeField]
	public ItemPosition itemPosition;

	public AnimationType animType;

	private Renderer[] renderers;

	private bool enableRenderingScheduled;

	public Vector3 StartLocalScale { get; private set; }

	private void Awake()
	{
	}

	protected virtual void OnEnable()
	{
	}

	private void Update()
	{
	}

	public virtual void OnEquipRight()
	{
	}

	public virtual void OnUnequipRight()
	{
	}

	public virtual void OnEquipLeft()
	{
	}

	public virtual void OnUnequipLeft()
	{
	}

	public virtual void OnIdleAnimStarted()
	{
	}

	public virtual void OnIdleAnimFinished()
	{
	}
}

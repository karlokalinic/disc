using UnityEngine;
using UnityEngine.UI;

public class HDRCheckbox : MonoBehaviour
{
	[SerializeField]
	private Toggle checkbox;

	protected string settingName;

	private TonemappingCamera hdrCamera;

	private void Awake()
	{
	}

	public void OnEnable()
	{
	}

	public void OnValueChanged(bool value)
	{
	}
}

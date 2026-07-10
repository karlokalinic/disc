using UnityEngine;
using UnityEngine.UI;

public class MaterialValueUpdater : MonoBehaviour
{
	public float value;

	[SerializeField]
	private Material decreaseMaterial;

	private Image image;

	private float currentValue;

	private Material baseMaterial;

	private Material localCopyDecreaseMaterial;

	private static readonly int valueShaderProperty;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	public void SetNormalMaterial()
	{
	}

	public void SetDecreaseMaterial()
	{
	}
}

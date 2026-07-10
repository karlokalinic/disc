using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BinaryTextColorer : MonoBehaviour
{
	[SerializeField]
	private Color _onColor;

	[SerializeField]
	private Color _offColor;

	private Text _text;

	private TextMeshProUGUI _textMeshPro;

	private void Awake()
	{
	}

	public void ChangeColorActivity(bool isOn)
	{
	}
}

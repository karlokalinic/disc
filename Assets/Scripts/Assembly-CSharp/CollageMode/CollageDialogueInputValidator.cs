using TMPro;
using UnityEngine;

namespace CollageMode
{
	[CreateAssetMenu]
	public class CollageDialogueInputValidator : TMP_InputValidator
	{
		public override char Validate(ref string text, ref int pos, char ch)
		{
			return '\0';
		}
	}
}

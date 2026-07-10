namespace PixelCrushers.DialogueSystem.SequencerCommands
{
	public class SequencerCommandQTE : SequencerCommand
	{
		private int index;

		private float stopTime;

		private string button;

		private string variableName;

		private string variableQTEValue;

		private FieldType variableType;

		public void Start()
		{
		}

		private FieldType GetVariableType()
		{
			return default(FieldType);
		}

		public void Update()
		{
		}

		public void OnDestroy()
		{
		}
	}
}

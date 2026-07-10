using PixelCrushers.DialogueSystem;

public class FinalResponseText
{
	public Response response;

	public string responseText;

	public string checkText;

	public bool visible;

	private bool _enabled;

	public bool HasCheck => false;

	public bool enabled
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public FinalResponseText(Response response, string responseText)
	{
	}

	public FinalResponseText(Response response)
	{
	}
}

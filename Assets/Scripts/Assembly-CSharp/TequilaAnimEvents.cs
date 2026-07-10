using System;
using System.Runtime.CompilerServices;

public class TequilaAnimEvents : LiteSingleton<TequilaAnimEvents>
{
	public event Action OnBedIdleFinish
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action OnGetUpFromBedFinished
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public void BedIdleFinish()
	{
	}

	public void GetUpFromBedFinished()
	{
	}
}

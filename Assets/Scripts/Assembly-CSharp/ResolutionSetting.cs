using System.Collections.Generic;

public struct ResolutionSetting
{
	public int w;

	public int h;

	public Aspect aspect;

	public Bars bars;

	public string name;

	public static Dictionary<string, ResolutionSetting> registry;

	public static readonly string[] aspectNames;

	public ResolutionSetting(int _w, int _h, Aspect _aspect, Bars _bars)
	{
		w = 0;
		h = 0;
		aspect = default(Aspect);
		bars = default(Bars);
		name = null;
	}

	public ResolutionSetting(int _w, int _h)
	{
		w = 0;
		h = 0;
		aspect = default(Aspect);
		bars = default(Bars);
		name = null;
	}

	public static ResolutionSetting Load()
	{
		return default(ResolutionSetting);
	}
}

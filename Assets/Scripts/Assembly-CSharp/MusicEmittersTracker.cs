using System.Collections.Generic;
using Voidforge;

public class MusicEmittersTracker : SingletonComponent<MusicEmittersTracker>
{
	private List<MusicEmitter> musicEmitters;

	private MusicEmitter playingMusicEmitter;

	private bool listenForEmitters;

	private string environmentSong;

	public bool ListenForEmitters
	{
		set
		{
		}
	}

	public string EnvironmentSong
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private void Update()
	{
	}

	public void Add(MusicEmitter me)
	{
	}

	public void Remove(MusicEmitter me)
	{
	}
}

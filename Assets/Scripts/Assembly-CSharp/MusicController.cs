using System.Collections;
using UnityEngine;
using Voidforge;

public class MusicController : SingletonComponent<MusicController>
{
	private bool hasStarted;

	private string currentSong;

	private string previousSong;

	private const float priorityDecayTime = 1f;

	public bool priorityDecayToggle;

	private float fade;

	private bool trackChanged;

	private float trackChangeTimer;

	private string playlistController;

	public bool ignoreSongWhenPrevious;

	[TextArea]
	public string Notes;

	public string CurrentSong
	{
		set
		{
		}
	}

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	public void ChangeTrack(string newPlaylist, string newSong, float newPriority)
	{
	}

	private IEnumerator CrossFadePlaylists(string newPlaylist, string newSong)
	{
		return null;
	}

	private IEnumerator TrackChangeReset()
	{
		return null;
	}
}

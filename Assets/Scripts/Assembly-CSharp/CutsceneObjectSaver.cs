using UnityEngine;

public class CutsceneObjectSaver : MonoBehaviour
{
	[SerializeField]
	private string saveName;

	private Animator anim;

	private CutsceneObjectHandler cutsceneObjectHandler;

	public string SaveName => null;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void Init(CutsceneObjectState state)
	{
	}

	public CutsceneObjectState GetState()
	{
		return default(CutsceneObjectState);
	}
}

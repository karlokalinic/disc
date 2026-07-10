using System;
using UnityEngine;

[Serializable]
public class SaveSlotDesc
{
	[SerializeField]
	private int version;

	[SerializeField]
	private string dateCreatedUTC;

	[SerializeField]
	private string uniqueName;

	[SerializeField]
	private string fileName;

	[SerializeField]
	private string title;

	[SerializeField]
	private string subTitle;

	public int Version => 0;

	public string UniqueName
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string FileName => null;

	public string Title => null;

	public string SubTitle => null;

	public SaveSlotDesc(DateTime dateCreated, string fileName, string title, string subTitle = "")
	{
	}

	public byte[] ToJsonBytes()
	{
		return null;
	}

	public static SaveSlotDesc FromJsonBytes(byte[] bytes)
	{
		return null;
	}
}

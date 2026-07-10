using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class SaveSlotCache
{
	[SerializeField]
	private List<SaveSlotDesc> cache;

	private Dictionary<string, SaveSlotDesc> uniqueNameToSlot;

	private Dictionary<string, SaveSlotDesc> fileNameToSlot;

	public int Count => 0;

	public void Clear()
	{
	}

	public void Add(SaveSlotDesc slot)
	{
	}

	public void Remove(SaveSlotDesc slot)
	{
	}

	public SaveSlotDesc FindSlotByUniqueName(string uniqueName)
	{
		return null;
	}

	public SaveSlotDesc FindSlotByFileName(string fileName)
	{
		return null;
	}

	public bool ContainsByUniqueName(string uniqueName)
	{
		return false;
	}

	public string UniqueNameToFileName(string uniqueName)
	{
		return null;
	}

	public string FileNameToUniqueName(string fileName)
	{
		return null;
	}

	private SaveSlotCache Populate()
	{
		return null;
	}

	public byte[] ToJsonBytes()
	{
		return null;
	}

	public static SaveSlotCache FromJsonBytes(byte[] bytes)
	{
		return null;
	}
}

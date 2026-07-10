using System;
using UnityEngine;

[CreateAssetMenu]
public class PagesRecordList : ScriptableObject
{
	[Serializable]
	public class PageRecord
	{
		public string path;

		public bool load;

		public PageRecord()
		{
		}

		public PageRecord(string path, bool load)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}

	public PageRecord[] records;

	public void UpdateAllRecords()
	{
	}
}

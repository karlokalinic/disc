using System.Collections.Generic;

namespace PixelCrushers.DialogueSystem
{
	public class DatabaseManager
	{
		private DialogueDatabase m_masterDatabase;

		private List<DialogueDatabase> m_loadedDatabases;

		public DialogueDatabase defaultDatabase { get; set; }

		public DialogueDatabase masterDatabase => null;

		public DialogueDatabase DefaultDatabase
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public DialogueDatabase MasterDatabase => null;

		public DatabaseManager(DialogueDatabase defaultDatabase = null)
		{
		}

		private DialogueDatabase GetMasterDatabase()
		{
			return null;
		}

		public void Add(DialogueDatabase database)
		{
		}

		public void Remove(DialogueDatabase database)
		{
		}

		public void Clear()
		{
		}

		public void Reset(DatabaseResetOptions databaseResetOptions = DatabaseResetOptions.RevertToDefault)
		{
		}

		private void ResetToDefaultDatabase()
		{
		}

		private void ResetToLoadedDatabases()
		{
		}
	}
}

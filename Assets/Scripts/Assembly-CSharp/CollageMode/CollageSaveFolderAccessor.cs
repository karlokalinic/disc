using System;
using System.Collections;
using Voidforge;

namespace CollageMode
{
	public class CollageSaveFolderAccessor : SingletonComponent<CollageSaveFolderAccessor>
	{
		public static SaveSlotCache CollageSlotCache;

		public IEnumerator SaveCollage(Action<SlotResult> callback, SaveSlotDesc slot, FileOpCommandBuffer fileCmdBuffer)
		{
			return null;
		}

		public IEnumerator LoadCollage(Action<SlotResult> callback, SaveSlotDesc slot, FileOpCommandBuffer fileCmdBuffer)
		{
			return null;
		}

		private IEnumerator SlotExecute(Action<SlotResult> callback, FileOpCommandBuffer fileCmdBuffer, string slotName, string slotTitle, string slotSubTitle, SlotMountFlag mountFlag)
		{
			return null;
		}

		public IEnumerator SlotUnmount(Action<SlotResult> callback, SlotMountPoint mountPoint)
		{
			return null;
		}

		private static string SlotMountPath(string slotName = "")
		{
			return null;
		}

		public IEnumerator SlotMount(Action<SlotResult, SlotMountPoint> callback, string slotName, string slotTitle, string slotSubTitle, SlotMountFlag flag)
		{
			return null;
		}

		public bool SlotDelete(string slotName)
		{
			return false;
		}

		private IEnumerator SlotCacheMount(Action<SlotResult, SlotMountPoint> callback, SlotMountFlag flag)
		{
			return null;
		}

		private IEnumerator SlotCacheUnmount(Action<SlotResult> callback, SlotMountPoint mountPoint)
		{
			return null;
		}

		private IEnumerator SlotCacheExecute(Action<SlotResult> callback, FileOpCommandBuffer fileCmdBuffer, SlotMountFlag mountFlag)
		{
			return null;
		}

		private static string SlotCacheMountPath()
		{
			return null;
		}

		public bool HasSaveSlotCache()
		{
			return false;
		}

		public IEnumerator ReadSaveSlotCache()
		{
			return null;
		}

		public IEnumerator WriteSaveSlotCache(Action<SlotResult> callback = null)
		{
			return null;
		}

		public IEnumerator UpdateSaveSlotCache()
		{
			return null;
		}

		public bool SlotList(out string[] list)
		{
			list = null;
			return false;
		}
	}
}

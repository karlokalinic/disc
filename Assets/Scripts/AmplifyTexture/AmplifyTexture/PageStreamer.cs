using System.Collections.Generic;
using System.Threading;
using UnityEngine.Rendering;

namespace AmplifyTexture
{
	internal sealed class PageStreamer
	{
		private class AssetStream
		{
			public PageRequestPool requestPool;

			public PageDecoder decoder;

			public byte[] pageData;
		}

		private class AssetStreamSource
		{
			public VirtualTexture asset;

			public PageSequencer sequencer;

			public AssetStream main;

			public AssetStream[] secondary;
		}

		private class AssetStreamThread
		{
			public int index;

			public AutoResetEvent continueSignal;

			public ManualResetEvent waitingSignal;

			public Thread thread;
		}

		private AmplifyTextureCamera m_runtime;

		private AssetStreamSource[] m_streamSourcePool;

		private List<AssetStreamSource> m_streamSources;

		private AssetStreamThread[] m_streamThreads;

		private ManualResetEvent m_streamThreadTerminateSignal;

		private int m_streamThreadIndex;

		private int m_requestPoolSize;

		private int m_capacity;

		private Dictionary<Page, object> m_submitted;

		private ConcurrentQueue<Page> m_pendingQueue;

		private ConcurrentQueue<PageRequest> m_readyQueue;

		private CommandBuffer m_command;

		public int SubmittedCount => 0;

		internal PageStreamer(AmplifyTextureCamera runtime)
		{
		}

		internal void Reset()
		{
		}

		internal void Clear(int newThreadCount)
		{
		}

		internal void Destroy()
		{
		}

		private AssetStreamThread CreateThread(int index)
		{
			return null;
		}

		public void InitializeThreads(int count)
		{
		}

		public void ResetThreads()
		{
		}

		public void FinalizeThreads()
		{
		}

		private void LoadImmediate(Page page)
		{
		}

		private void LoadAsync(Page page)
		{
		}

		internal void Load(Page page, bool forceSync)
		{
		}

		private void StreamingThreadCallback(object obj)
		{
		}

		internal int UploadAvailablePages(int maxUploadCount)
		{
			return 0;
		}
	}
}

using System;
using UnityEngine;

namespace AmplifyTexture
{
	public sealed class PageDecoder
	{
		private IntPtr m_decoderHandle;

		private uint m_pageBlockSize;

		private uint m_pageBlockHeaderSize;

		private byte[] m_scratchData;

		private bool m_compressed;

		private bool m_activeGammaSpace;

		public byte[] m_tempDiff0;

		public byte[] m_tempNorm0;

		public byte[] m_tempNorm1;

		public byte[] m_tempSpec0;

		public byte[] m_tempSpec1;

		public byte[] ScratchData => null;

		public PageDecoder(int pageBlockSize, NativeRuntime.PlaneDesc[] planes, bool compressed = false)
		{
		}

		public PageDecoder(int pageBlockSize, NativeRuntime.PlaneDesc[] planes, ColorSpace activeColorSpace)
		{
		}

		public PageDecoder(int pageBlockSize, NativeRuntime.PlaneDesc[] planes, bool compressed, ColorSpace activeColorSpace)
		{
		}

		public void Destroy()
		{
		}

		public int DecodePage(byte[] input, uint inputSize, byte[] output, uint outputOffset)
		{
			return 0;
		}

		public bool DecodePage2(byte[] input, uint inputOffset, uint inputDiff0Length, uint inputNorm0Length, uint inputNorm1Length, uint inputSpec0Length, uint inputSpec1Length, PageRequest pageReq)
		{
			return false;
		}

		public void ConvertPageDataToPixels(byte[] pageData, bool linear, byte[] pageDiffuse, byte[] pageNormal, byte[] pageSpecular, bool alpha, bool normal, bool occlusion, bool displacement, bool specular)
		{
		}
	}
}

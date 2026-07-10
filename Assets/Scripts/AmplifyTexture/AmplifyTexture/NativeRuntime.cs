using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace AmplifyTexture
{
	public sealed class NativeRuntime
	{
		public enum RenderEvent
		{
			PREPASS_READBACK_QUEUE = 0
		}

		public enum CompType
		{
			CT_NONE = 0,
			CT_LOSSLESS = 1,
			CT_LOSSY = 2
		}

		public struct PlaneDesc
		{
			public byte numChannels;

			public byte compType;

			public byte compQuality;
		}

		private const string Module = "AmplifyTextureNative";

		[PreserveSig]
		public static extern IntPtr GetRenderEventFunc();

		[PreserveSig]
		public static extern IntPtr CreatePageDecoder(uint size, [In][Out] PlaneDesc[] planes, byte numPlanes);

		[PreserveSig]
		public static extern void DestroyPageDecoder(IntPtr handle);

		[PreserveSig]
		public static extern int DecodePage(IntPtr handle, ref byte input, uint inputSize, ref byte output, uint outputOffset);

		[PreserveSig]
		public static extern int TranscodeCrunchToBC(IntPtr handle, ref byte input, uint inputSize, ref byte output);

		[PreserveSig]
		public static extern int DecodeBC1ToRGBX(IntPtr handle, ref byte input, ref byte output);

		[PreserveSig]
		public static extern int DecodeBC3ToRGBA(IntPtr handle, ref byte input, ref byte output);

		[PreserveSig]
		public static extern int DecodeBC5ToRGBA(IntPtr handle, ref byte input, ref byte output, uint chan0, uint chan1);

		[PreserveSig]
		public static extern int DecodeETC1ToRGBX(IntPtr handle, ref byte input, ref byte output);

		[PreserveSig]
		public static extern int DecodeETC2ToRGBX(IntPtr handle, ref byte input, ref byte output);

		[PreserveSig]
		public static extern int DecodeETC2AToRGBA(IntPtr handle, ref byte input, ref byte output);

		[PreserveSig]
		public static extern int DecodeETC2AToRGBA2(IntPtr handle, ref byte input, ref byte output, uint chan0, uint chan1);

		[PreserveSig]
		public static extern int DecodePackedHeightRG(IntPtr handle, ref byte input, uint inputSize, ref byte output);

		[PreserveSig]
		public static extern IntPtr CreatePrePassHistogram(uint width, uint height, uint maxPageRefs);

		[PreserveSig]
		public static extern void DestroyPrePassHistogram(IntPtr inst);

		[PreserveSig]
		public static extern int BuildPrePassHistogram(IntPtr inst, ref Color32 pixelColors, ref PrePassHashEntry hashEntries, ref ushort pageRefs, ref AssetDesc assetDesc, uint assetCount);

		[PreserveSig]
		public static extern IntPtr CreatePrePassReadback(IntPtr tex, uint width, uint height);

		[PreserveSig]
		public static extern void DestroyPrePassReadback(IntPtr inst);

		[PreserveSig]
		public static extern void IssuePrePassRead(IntPtr inst);

		[PreserveSig]
		public static extern void GetPrePassPixels(IntPtr inst, ref Color32 pixels);
	}
}

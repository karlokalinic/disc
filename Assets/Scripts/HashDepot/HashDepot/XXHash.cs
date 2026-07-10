using System;
using System.Runtime.CompilerServices;

namespace HashDepot
{
	public static class XXHash
	{
		public static uint Hash32(ReadOnlySpan<byte> buffer, uint seed = 0u)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static (uint, uint, uint, uint) initAccumulators32(uint seed)
		{
			return default((uint, uint, uint, uint));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private unsafe static uint processStripe32(ref byte* pInput, ref uint acc1, ref uint acc2, ref uint acc3, ref uint acc4, bool bigEndian)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private unsafe static void processLane32(ref byte* pInput, ref uint accn)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private unsafe static void processLaneBigEndian32(ref byte* pInput, ref uint accn)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private unsafe static uint processRemaining32(byte* pInput, uint acc, int remainingLen, bool bigEndian)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static uint round32(uint accn, uint lane)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static uint avalanche32(uint acc)
		{
			return 0u;
		}
	}
}

namespace AmplifyTexture
{
	public struct TextureSource
	{
		public uint flags;

		public string value;

		public TextureSource(float luminance)
		{
			flags = 0u;
			value = null;
		}

		public TextureSource(string texturePath, bool invert, bool srgb)
		{
			flags = 0u;
			value = null;
		}
	}
}

namespace CollageMode
{
	public interface ISerializableManager
	{
		string SerializedCategoryName { get; }

		SerializableData Save();

		void Load(SerializableData data);
	}
}

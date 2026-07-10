using System;
using System.Collections.Generic;

namespace PixelCrushers.DialogueSystem.ChatMapper
{
	[Serializable]
	public class Assets
	{
		public List<Actor> Actors;

		public List<Item> Items;

		public List<Location> Locations;

		public List<Conversation> Conversations;

		public List<UserVariable> UserVariables;
	}
}

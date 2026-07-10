using System;

namespace InControl
{
	public class BindingListenOptions
	{
		public bool IncludeControllers;

		public bool IncludeUnknownControllers;

		public bool IncludeNonStandardControls;

		public bool IncludeMouseButtons;

		public bool IncludeMouseScrollWheel;

		public bool IncludeKeys;

		public bool IncludeModifiersAsFirstClassKeys;

		public uint MaxAllowedBindings;

		public uint MaxAllowedBindingsPerType;

		public bool AllowDuplicateBindingsPerSet;

		public bool UnsetDuplicateBindingsOnSet;

		public bool RejectRedundantBindings;

		public BindingSource ReplaceBinding;

		public Func<PlayerAction, BindingSource, bool> OnBindingFound;

		public Action<PlayerAction, BindingSource> OnBindingAdded;

		public Action<PlayerAction, BindingSource, BindingSourceRejectionType> OnBindingRejected;

		public Action<PlayerAction> OnBindingEnded;

		public bool CallOnBindingFound(PlayerAction playerAction, BindingSource bindingSource)
		{
			return false;
		}

		public void CallOnBindingAdded(PlayerAction playerAction, BindingSource bindingSource)
		{
		}

		public void CallOnBindingRejected(PlayerAction playerAction, BindingSource bindingSource, BindingSourceRejectionType bindingSourceRejectionType)
		{
		}

		public void CallOnBindingEnded(PlayerAction playerAction)
		{
		}
	}
}

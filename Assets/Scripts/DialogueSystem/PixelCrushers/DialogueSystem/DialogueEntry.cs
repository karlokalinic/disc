using System;
using System.Collections.Generic;
using PixelCrushers.DialogueSystem.ChatMapper;
using UnityEngine;
using UnityEngine.Events;

namespace PixelCrushers.DialogueSystem
{
	[Serializable]
	public class DialogueEntry
	{
		public int id;

		public List<Field> fields;

		public int conversationID;

		public bool isRoot;

		public bool isGroup;

		public string nodeColor;

		public bool delaySimStatus;

		public string falseConditionAction;

		public ConditionPriority conditionPriority;

		public List<Link> outgoingLinks;

		public string conditionsString;

		public string userScript;

		public UnityEvent onExecute;

		public const float CanvasRectWidth = 160f;

		public const float CanvasRectHeight = 30f;

		public Rect canvasRect;

		public int ActorID
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int ConversantID
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public string Title
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string currentMenuText
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string MenuText
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string currentLocalizedMenuText
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string currentDialogueText
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string DialogueText
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string currentLocalizedDialogueText
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string subtitleText => null;

		public string responseButtonText => null;

		public string currentSequence
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string Sequence
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string currentLocalizedSequence
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string currentResponseMenuSequence
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string ResponseMenuSequence
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string currentLocalizedResponseMenuSequence
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string VideoFile
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string AudioFiles
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string AnimationFiles
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string LipsyncFiles
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private Field GetCurrentMenuTextField()
		{
			return null;
		}

		private Field GetCurrentDialogueTextField()
		{
			return null;
		}

		private Field GetCurrentSequenceField()
		{
			return null;
		}

		private void SetCurrentSequenceField(string value)
		{
		}

		private void SetTextField(string title, string value)
		{
		}

		public bool HasResponseMenuSequence()
		{
			return false;
		}

		private Field GetCurrentResponseMenuSequenceField()
		{
			return null;
		}

		private void SetCurrentResponseMenuSequenceField(string value)
		{
		}

		public DialogueEntry()
		{
		}

		public DialogueEntry(DialogEntry chatMapperDialogEntry)
		{
		}

		public void UseCanvasRectField()
		{
		}

		public DialogueEntry(DialogueEntry sourceEntry)
		{
		}

		private List<Link> CopyLinks(List<Link> sourceLinks)
		{
			return null;
		}
	}
}

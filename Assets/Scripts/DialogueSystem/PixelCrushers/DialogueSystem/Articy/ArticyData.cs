using System.Collections.Generic;
using UnityEngine;

namespace PixelCrushers.DialogueSystem.Articy
{
	public class ArticyData
	{
		public class LocalizableText
		{
			public Dictionary<string, string> localizedString;

			public string DefaultText => null;
		}

		public class Element
		{
			public string id;

			public string technicalName;

			public LocalizableText displayName;

			public LocalizableText text;

			public Features features;

			public Vector2 position;

			public Element()
			{
			}

			public Element(string id, string technicalName, LocalizableText displayName, LocalizableText text, Features features, Vector2 position)
			{
			}
		}

		public class Project
		{
			public string displayName;

			public string createdOn;

			public string creatorTool;

			public string creatorVersion;
		}

		public class Asset : Element
		{
			public string assetFilename;

			public Asset()
			{
			}

			public Asset(string id, string technicalName, LocalizableText displayName, LocalizableText text, Features features, Vector2 position, string assetFilename)
			{
			}
		}

		public class Entity : Element
		{
			public string previewImage;

			public Entity()
			{
			}

			public Entity(string id, string technicalName, LocalizableText displayName, LocalizableText text, Features features, Vector2 position, string previewImage)
			{
			}
		}

		public class Location : Element
		{
			public Location()
			{
			}

			public Location(string id, string technicalName, LocalizableText displayName, LocalizableText text, Features features, Vector2 position)
			{
			}
		}

		public class FlowFragment : Element
		{
			public List<Pin> pins;

			public FlowFragment()
			{
			}

			public FlowFragment(string id, string technicalName, LocalizableText displayName, LocalizableText text, Features features, Vector2 position, List<Pin> pins)
			{
			}
		}

		public class Dialogue : Element
		{
			public List<Pin> pins;

			public List<string> references;

			public bool isDocument;

			public Dialogue()
			{
			}

			public Dialogue(string id, string technicalName, LocalizableText displayName, LocalizableText text, Features features, Vector2 position, List<Pin> pins, List<string> references, bool isDocument = false)
			{
			}
		}

		public class DialogueFragment : Element
		{
			public LocalizableText menuText;

			public LocalizableText stageDirections;

			public string speakerIdRef;

			public List<Pin> pins;

			public DialogueFragment()
			{
			}

			public DialogueFragment(string id, string technicalName, LocalizableText displayName, LocalizableText text, Features features, Vector2 position, LocalizableText menuText, LocalizableText stageDirections, string speakerIdRef, List<Pin> pins)
			{
			}
		}

		public class Hub : Element
		{
			public List<Pin> pins;

			public Hub()
			{
			}

			public Hub(string id, string technicalName, LocalizableText displayName, LocalizableText text, Features features, Vector2 position, List<Pin> pins)
			{
			}
		}

		public class Jump : Element
		{
			public ConnectionRef target;

			public List<Pin> pins;

			public Jump()
			{
			}

			public Jump(string id, string technicalName, LocalizableText displayName, LocalizableText text, Features features, Vector2 position, ConnectionRef target, List<Pin> pins)
			{
			}
		}

		public class ConnectionRef
		{
			public string idRef;

			public string pinRef;

			public ConnectionRef()
			{
			}

			public ConnectionRef(string idRef, string pinRef)
			{
			}
		}

		public class Connection
		{
			public string id;

			public string color;

			public ConnectionRef source;

			public ConnectionRef target;

			public Connection()
			{
			}

			public Connection(string id, string color, ConnectionRef source, ConnectionRef target)
			{
			}
		}

		public class Condition
		{
			public string id;

			public string expression;

			public List<Pin> pins;

			public Vector2 position;

			public Condition()
			{
			}

			public Condition(string id, string expression, List<Pin> pins, Vector2 position)
			{
			}

			public Condition(string id, string expression, List<Pin> pins)
			{
			}
		}

		public class Instruction
		{
			public string id;

			public string expression;

			public List<Pin> pins;

			public Vector2 position;

			public Instruction()
			{
			}

			public Instruction(string id, string expression, List<Pin> pins, Vector2 position)
			{
			}

			public Instruction(string id, string expression, List<Pin> pins)
			{
			}
		}

		public enum SemanticType
		{
			Input = 0,
			Output = 1
		}

		public class Pin
		{
			public string id;

			public int index;

			public SemanticType semantic;

			public string expression;

			public Pin()
			{
			}

			public Pin(string id, int index, SemanticType semantic, string expression)
			{
			}
		}

		public enum VariableDataType
		{
			Boolean = 0,
			Integer = 1,
			String = 2
		}

		public class Variable
		{
			public string technicalName;

			public string defaultValue;

			public VariableDataType dataType;

			public string description;

			public Variable()
			{
			}

			public Variable(string technicalName, string defaultValue, VariableDataType dataType)
			{
			}

			public Variable(string technicalName, string defaultValue, VariableDataType dataType, string description)
			{
			}
		}

		public class VariableSet
		{
			public string id;

			public string technicalName;

			public List<Variable> variables;

			public VariableSet()
			{
			}

			public VariableSet(string id, string technicalName, List<Variable> variables)
			{
			}
		}

		public class Features
		{
			public List<Feature> features;

			public Features()
			{
			}

			public Features(List<Feature> features)
			{
			}
		}

		public class Feature
		{
			public List<Property> properties;

			public Feature()
			{
			}

			public Feature(List<Property> properties)
			{
			}
		}

		public class Property
		{
			public List<Field> fields;

			public Property()
			{
			}

			public Property(List<Field> fields)
			{
			}
		}

		public enum NodeType
		{
			FlowFragment = 0,
			Dialogue = 1,
			DialogueFragment = 2,
			Hub = 3,
			Jump = 4,
			Connection = 5,
			Condition = 6,
			Instruction = 7,
			Other = 8
		}

		public class Node
		{
			public string id;

			public NodeType type;

			public List<Node> nodes;

			public Node()
			{
			}

			public Node(string id, NodeType nodeType, List<Node> nodes)
			{
			}
		}

		public class Hierarchy
		{
			public Node node;

			public Hierarchy()
			{
			}

			public Hierarchy(Node node)
			{
			}
		}

		public Project project;

		public Dictionary<string, Asset> assets;

		public Dictionary<string, Entity> entities;

		public Dictionary<string, Location> locations;

		public Dictionary<string, FlowFragment> flowFragments;

		public Dictionary<string, Dialogue> dialogues;

		public Dictionary<string, DialogueFragment> dialogueFragments;

		public Dictionary<string, Hub> hubs;

		public Dictionary<string, Jump> jumps;

		public Dictionary<string, Connection> connections;

		public Dictionary<string, Condition> conditions;

		public Dictionary<string, Instruction> instructions;

		public Dictionary<string, VariableSet> variableSets;

		public List<string> textTableFields;

		public Hierarchy hierarchy;

		public const string HighPriorityColor = "#FF0000";

		public const string AboveNormalPriorityColor = "#FFC000";

		public const string BelowNormalPriorityColor = "#FFFF00";

		public const string LowPriorityColor = "#92D050";

		public string ProjectTitle => null;

		public string ProjectVersion => null;

		public string ProjectAuthor => null;

		public static string FullVariableName(VariableSet variableSet, Variable variable)
		{
			return null;
		}

		public static ConditionPriority ColorToPriority(string color)
		{
			return default(ConditionPriority);
		}
	}
}

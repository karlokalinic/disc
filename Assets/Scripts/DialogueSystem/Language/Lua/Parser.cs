using System.Collections.Generic;

namespace Language.Lua
{
	public class Parser
	{
		private enum ResultKeyType
		{
			Access = 0,
			ArgList = 1,
			Args = 2,
			Assignment = 3,
			BaseExpr = 4,
			BinaryOperator = 5,
			BoolLiteral = 6,
			BreakStmt = 7,
			Chunk = 8,
			DoStmt = 9,
			DoubleQuotedText = 10,
			ElseifBlock = 11,
			Expr = 12,
			ExprList = 13,
			ExprStmt = 14,
			Field = 15,
			FieldList = 16,
			FloatNumber = 17,
			ForInStmt = 18,
			ForStmt = 19,
			FullName = 20,
			Function = 21,
			FunctionBody = 22,
			FunctionCall = 23,
			FunctionName = 24,
			FunctionValue = 25,
			GroupExpr = 26,
			HexicalNumber = 27,
			IfStmt = 28,
			ItemValue = 29,
			KeyAccess = 30,
			KeyValue = 31,
			LocalFunc = 32,
			LocalVar = 33,
			LongString = 34,
			MethodCall = 35,
			Name = 36,
			NameAccess = 37,
			NameList = 38,
			NameValue = 39,
			NilLiteral = 40,
			NumberLiteral = 41,
			OperatorExpr = 42,
			ParamList = 43,
			PrimaryExpr = 44,
			RepeatStmt = 45,
			ReturnStmt = 46,
			SingleQuotedText = 47,
			Statement = 48,
			StringLiteral = 49,
			TableConstructor = 50,
			Term = 51,
			UnaryOperator = 52,
			Var = 53,
			VarList = 54,
			VarName = 55,
			VariableArg = 56,
			WhileStmt = 57
		}

		public struct ResultValue
		{
			public object Item1;

			public bool Item2;

			public int Item3;

			public ResultValue(object item1, bool item2, int item3)
			{
				Item1 = null;
				Item2 = false;
				Item3 = 0;
			}
		}

		private int position;

		private ParserInput<char> Input;

		private Stack<int> ErrorStack;

		public Dictionary<long, ResultValue> ParsingResults;

		public int Position
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int ErrorCount { get; private set; }

		public Chunk ParseChunk(ParserInput<char> input, out bool success)
		{
			success = default(bool);
			return null;
		}

		private Chunk ParseChunk(out bool success)
		{
			success = default(bool);
			return null;
		}

		private Statement ParseStatement(out bool success)
		{
			success = default(bool);
			return null;
		}

		private Assignment ParseAssignment(out bool success)
		{
			success = default(bool);
			return null;
		}

		private Function ParseFunction(out bool success)
		{
			success = default(bool);
			return null;
		}

		private LocalVar ParseLocalVar(out bool success)
		{
			success = default(bool);
			return null;
		}

		private LocalFunc ParseLocalFunc(out bool success)
		{
			success = default(bool);
			return null;
		}

		private ExprStmt ParseExprStmt(out bool success)
		{
			success = default(bool);
			return null;
		}

		private ReturnStmt ParseReturnStmt(out bool success)
		{
			success = default(bool);
			return null;
		}

		private BreakStmt ParseBreakStmt(out bool success)
		{
			success = default(bool);
			return null;
		}

		private DoStmt ParseDoStmt(out bool success)
		{
			success = default(bool);
			return null;
		}

		private IfStmt ParseIfStmt(out bool success)
		{
			success = default(bool);
			return null;
		}

		private ElseifBlock ParseElseifBlock(out bool success)
		{
			success = default(bool);
			return null;
		}

		private ForStmt ParseForStmt(out bool success)
		{
			success = default(bool);
			return null;
		}

		private ForInStmt ParseForInStmt(out bool success)
		{
			success = default(bool);
			return null;
		}

		private WhileStmt ParseWhileStmt(out bool success)
		{
			success = default(bool);
			return null;
		}

		private RepeatStmt ParseRepeatStmt(out bool success)
		{
			success = default(bool);
			return null;
		}

		private List<Var> ParseVarList(out bool success)
		{
			success = default(bool);
			return null;
		}

		private List<Expr> ParseExprList(out bool success)
		{
			success = default(bool);
			return null;
		}

		private Expr ParseExpr(out bool success)
		{
			success = default(bool);
			return null;
		}

		private Term ParseTerm(out bool success)
		{
			success = default(bool);
			return null;
		}

		private NilLiteral ParseNilLiteral(out bool success)
		{
			success = default(bool);
			return null;
		}

		private BoolLiteral ParseBoolLiteral(out bool success)
		{
			success = default(bool);
			return null;
		}

		private NumberLiteral ParseNumberLiteral(out bool success)
		{
			success = default(bool);
			return null;
		}

		private StringLiteral ParseStringLiteral(out bool success)
		{
			success = default(bool);
			return null;
		}

		private VariableArg ParseVariableArg(out bool success)
		{
			success = default(bool);
			return null;
		}

		private FunctionValue ParseFunctionValue(out bool success)
		{
			success = default(bool);
			return null;
		}

		private FunctionBody ParseFunctionBody(out bool success)
		{
			success = default(bool);
			return null;
		}

		private Access ParseAccess(out bool success)
		{
			success = default(bool);
			return null;
		}

		private BaseExpr ParseBaseExpr(out bool success)
		{
			success = default(bool);
			return null;
		}

		private KeyAccess ParseKeyAccess(out bool success)
		{
			success = default(bool);
			return null;
		}

		private NameAccess ParseNameAccess(out bool success)
		{
			success = default(bool);
			return null;
		}

		private MethodCall ParseMethodCall(out bool success)
		{
			success = default(bool);
			return null;
		}

		private FunctionCall ParseFunctionCall(out bool success)
		{
			success = default(bool);
			return null;
		}

		private Var ParseVar(out bool success)
		{
			success = default(bool);
			return null;
		}

		private PrimaryExpr ParsePrimaryExpr(out bool success)
		{
			success = default(bool);
			return null;
		}

		private VarName ParseVarName(out bool success)
		{
			success = default(bool);
			return null;
		}

		private FunctionName ParseFunctionName(out bool success)
		{
			success = default(bool);
			return null;
		}

		private GroupExpr ParseGroupExpr(out bool success)
		{
			success = default(bool);
			return null;
		}

		private TableConstructor ParseTableConstructor(out bool success)
		{
			success = default(bool);
			return null;
		}

		private List<Field> ParseFieldList(out bool success)
		{
			success = default(bool);
			return null;
		}

		private Field ParseField(out bool success)
		{
			success = default(bool);
			return null;
		}

		private KeyValue ParseKeyValue(out bool success)
		{
			success = default(bool);
			return null;
		}

		private NameValue ParseNameValue(out bool success)
		{
			success = default(bool);
			return null;
		}

		private ItemValue ParseItemValue(out bool success)
		{
			success = default(bool);
			return null;
		}

		private OperatorExpr ParseOperatorExpr(out bool success)
		{
			success = default(bool);
			return null;
		}

		private Args ParseArgs(out bool success)
		{
			success = default(bool);
			return null;
		}

		private List<Expr> ParseArgList(out bool success)
		{
			success = default(bool);
			return null;
		}

		private ParamList ParseParamList(out bool success)
		{
			success = default(bool);
			return null;
		}

		private List<string> ParseFullName(out bool success)
		{
			success = default(bool);
			return null;
		}

		private List<string> ParseNameList(out bool success)
		{
			success = default(bool);
			return null;
		}

		private string ParseName(out bool success)
		{
			success = default(bool);
			return null;
		}

		private string ParseFloatNumber(out bool success)
		{
			success = default(bool);
			return null;
		}

		private string ParseHexicalNumber(out bool success)
		{
			success = default(bool);
			return null;
		}

		private string ParseSingleQuotedText(out bool success)
		{
			success = default(bool);
			return null;
		}

		private string ParseDoubleQuotedText(out bool success)
		{
			success = default(bool);
			return null;
		}

		private string ParseLongString(out bool success)
		{
			success = default(bool);
			return null;
		}

		private void ParseKeyword(out bool success)
		{
			success = default(bool);
		}

		private char ParseDigit(out bool success)
		{
			success = default(bool);
			return '\0';
		}

		private char ParseHexDigit(out bool success)
		{
			success = default(bool);
			return '\0';
		}

		private char ParseLetter(out bool success)
		{
			success = default(bool);
			return '\0';
		}

		private string ParseUnaryOperator(out bool success)
		{
			success = default(bool);
			return null;
		}

		private string ParseBinaryOperator(out bool success)
		{
			success = default(bool);
			return null;
		}

		private void ParseWordSep(out bool success)
		{
			success = default(bool);
		}

		private void ParseFieldSep(out bool success)
		{
			success = default(bool);
		}

		private void ParseSpReq(out bool success)
		{
			success = default(bool);
		}

		private void ParseSpOpt(out bool success)
		{
			success = default(bool);
		}

		private void ParseComment(out bool success)
		{
			success = default(bool);
		}

		private void ParseEol(out bool success)
		{
			success = default(bool);
		}

		private void ParseEof(out bool success)
		{
			success = default(bool);
		}

		private char ParseEscapeChar(out bool success)
		{
			success = default(bool);
			return '\0';
		}

		public void SetInput(ParserInput<char> input)
		{
		}

		private bool TerminalMatch(char terminal)
		{
			return false;
		}

		private bool TerminalMatch(char terminal, int pos)
		{
			return false;
		}

		private char MatchTerminal(char terminal, out bool success)
		{
			success = default(bool);
			return '\0';
		}

		private char MatchTerminalRange(char start, char end, out bool success)
		{
			success = default(bool);
			return '\0';
		}

		private char MatchTerminalSet(string terminalSet, bool isComplement, out bool success)
		{
			success = default(bool);
			return '\0';
		}

		private string MatchTerminalString(string terminalString, out bool success)
		{
			success = default(bool);
			return null;
		}

		public bool PeekTerminalString(string terminalString)
		{
			return false;
		}

		private int Error(string message)
		{
			return 0;
		}

		private void ClearError(int count)
		{
		}

		public string GetEorrorMessages()
		{
			return null;
		}

		private static long MakeResultKey(int position, ResultKeyType type)
		{
			return 0L;
		}
	}
}

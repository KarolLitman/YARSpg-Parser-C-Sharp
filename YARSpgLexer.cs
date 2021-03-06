//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.7.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from YARSpg.g4 by ANTLR 4.7.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using System;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7.1")]
[System.CLSCompliant(false)]
public partial class YARSpgLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, T__7=8, T__8=9, 
		T__9=10, STRING=11, NUMBER=12, NULL=13, TRUE_FALSE=14, STRING_LITERAL_QUOTE=15, 
		ALNUM_PLUS=16, PN_CHARS=17, PN_CHARS_U=18, UCHAR=19, PN_CHARS_BASE=20, 
		HEX=21, SP=22, NL=23;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "T__1", "T__2", "T__3", "T__4", "T__5", "T__6", "T__7", "T__8", 
		"T__9", "STRING", "NUMBER", "NULL", "TRUE_FALSE", "STRING_LITERAL_QUOTE", 
		"ALNUM_PLUS", "PN_CHARS", "PN_CHARS_U", "UCHAR", "PN_CHARS_BASE", "HEX", 
		"SP", "NL"
	};


	public YARSpgLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public YARSpgLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, "'['", "':'", "']'", "'{'", "','", "'}'", "'('", "')'", "'-'", "'->'", 
		null, null, "'null'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, null, null, null, null, null, "STRING", 
		"NUMBER", "NULL", "TRUE_FALSE", "STRING_LITERAL_QUOTE", "ALNUM_PLUS", 
		"PN_CHARS", "PN_CHARS_U", "UCHAR", "PN_CHARS_BASE", "HEX", "SP", "NL"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "YARSpg.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static YARSpgLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x2', '\x19', '\xA9', '\b', '\x1', '\x4', '\x2', '\t', '\x2', 
		'\x4', '\x3', '\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', 
		'\x5', '\x4', '\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', '\x4', '\b', 
		'\t', '\b', '\x4', '\t', '\t', '\t', '\x4', '\n', '\t', '\n', '\x4', '\v', 
		'\t', '\v', '\x4', '\f', '\t', '\f', '\x4', '\r', '\t', '\r', '\x4', '\xE', 
		'\t', '\xE', '\x4', '\xF', '\t', '\xF', '\x4', '\x10', '\t', '\x10', '\x4', 
		'\x11', '\t', '\x11', '\x4', '\x12', '\t', '\x12', '\x4', '\x13', '\t', 
		'\x13', '\x4', '\x14', '\t', '\x14', '\x4', '\x15', '\t', '\x15', '\x4', 
		'\x16', '\t', '\x16', '\x4', '\x17', '\t', '\x17', '\x4', '\x18', '\t', 
		'\x18', '\x3', '\x2', '\x3', '\x2', '\x3', '\x3', '\x3', '\x3', '\x3', 
		'\x4', '\x3', '\x4', '\x3', '\x5', '\x3', '\x5', '\x3', '\x6', '\x3', 
		'\x6', '\x3', '\a', '\x3', '\a', '\x3', '\b', '\x3', '\b', '\x3', '\t', 
		'\x3', '\t', '\x3', '\n', '\x3', '\n', '\x3', '\v', '\x3', '\v', '\x3', 
		'\v', '\x3', '\f', '\x3', '\f', '\x3', '\r', '\x6', '\r', 'J', '\n', '\r', 
		'\r', '\r', '\xE', '\r', 'K', '\x3', '\r', '\x5', '\r', 'O', '\n', '\r', 
		'\x3', '\r', '\a', '\r', 'R', '\n', '\r', '\f', '\r', '\xE', '\r', 'U', 
		'\v', '\r', '\x3', '\xE', '\x3', '\xE', '\x3', '\xE', '\x3', '\xE', '\x3', 
		'\xE', '\x3', '\xF', '\x3', '\xF', '\x3', '\xF', '\x3', '\xF', '\x3', 
		'\xF', '\x3', '\xF', '\x3', '\xF', '\x3', '\xF', '\x3', '\xF', '\x5', 
		'\xF', '\x65', '\n', '\xF', '\x3', '\x10', '\x3', '\x10', '\x3', '\x10', 
		'\x3', '\x10', '\x3', '\x10', '\a', '\x10', 'l', '\n', '\x10', '\f', '\x10', 
		'\xE', '\x10', 'o', '\v', '\x10', '\x3', '\x10', '\x3', '\x10', '\x3', 
		'\x11', '\x3', '\x11', '\x3', '\x11', '\a', '\x11', 'v', '\n', '\x11', 
		'\f', '\x11', '\xE', '\x11', 'y', '\v', '\x11', '\x3', '\x11', '\x5', 
		'\x11', '|', '\n', '\x11', '\x3', '\x12', '\x3', '\x12', '\x5', '\x12', 
		'\x80', '\n', '\x12', '\x3', '\x13', '\x3', '\x13', '\x5', '\x13', '\x84', 
		'\n', '\x13', '\x3', '\x14', '\x3', '\x14', '\x3', '\x14', '\x3', '\x14', 
		'\x3', '\x14', '\x3', '\x14', '\x3', '\x14', '\x3', '\x14', '\x3', '\x14', 
		'\x3', '\x14', '\x3', '\x14', '\x3', '\x14', '\x3', '\x14', '\x3', '\x14', 
		'\x3', '\x14', '\x3', '\x14', '\x3', '\x14', '\x3', '\x14', '\x3', '\x14', 
		'\x3', '\x14', '\x5', '\x14', '\x9A', '\n', '\x14', '\x3', '\x15', '\x3', 
		'\x15', '\x3', '\x16', '\x5', '\x16', '\x9F', '\n', '\x16', '\x3', '\x17', 
		'\x6', '\x17', '\xA2', '\n', '\x17', '\r', '\x17', '\xE', '\x17', '\xA3', 
		'\x3', '\x17', '\x3', '\x17', '\x3', '\x18', '\x3', '\x18', '\x2', '\x2', 
		'\x19', '\x3', '\x3', '\x5', '\x4', '\a', '\x5', '\t', '\x6', '\v', '\a', 
		'\r', '\b', '\xF', '\t', '\x11', '\n', '\x13', '\v', '\x15', '\f', '\x17', 
		'\r', '\x19', '\xE', '\x1B', '\xF', '\x1D', '\x10', '\x1F', '\x11', '!', 
		'\x12', '#', '\x13', '%', '\x14', '\'', '\x15', ')', '\x16', '+', '\x17', 
		'-', '\x18', '/', '\x19', '\x3', '\x2', '\t', '\x3', '\x2', '\x32', ';', 
		'\x6', '\x2', '\f', '\f', '\xF', '\xF', '$', '$', '^', '^', '\a', '\x2', 
		'/', '/', '\x32', ';', '\xB9', '\xB9', '\x302', '\x371', '\x2041', '\x2042', 
		'\x10', '\x2', '\x32', ';', '\x43', '\\', '\x63', '|', '\xC2', '\xD8', 
		'\xDA', '\xF8', '\xFA', '\x301', '\x372', '\x37F', '\x381', '\x2001', 
		'\x200E', '\x200F', '\x2072', '\x2191', '\x2C02', '\x2FF1', '\x3003', 
		'\xD801', '\xF902', '\xFDD1', '\xFDF2', '\xFFFF', '\x5', '\x2', '\x32', 
		';', '\x43', 'H', '\x63', 'h', '\x4', '\x2', '\v', '\v', '\"', '\"', '\x4', 
		'\x2', '\f', '\f', '\xF', '\xF', '\x2', '\xB6', '\x2', '\x3', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\x5', '\x3', '\x2', '\x2', '\x2', '\x2', '\a', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\t', '\x3', '\x2', '\x2', '\x2', '\x2', '\v', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\r', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\xF', '\x3', '\x2', '\x2', '\x2', '\x2', '\x11', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\x13', '\x3', '\x2', '\x2', '\x2', '\x2', '\x15', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\x17', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\x19', '\x3', '\x2', '\x2', '\x2', '\x2', '\x1B', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\x1D', '\x3', '\x2', '\x2', '\x2', '\x2', '\x1F', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '!', '\x3', '\x2', '\x2', '\x2', '\x2', '#', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '%', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\'', '\x3', '\x2', '\x2', '\x2', '\x2', ')', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '+', '\x3', '\x2', '\x2', '\x2', '\x2', '-', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '/', '\x3', '\x2', '\x2', '\x2', '\x3', '\x31', '\x3', '\x2', 
		'\x2', '\x2', '\x5', '\x33', '\x3', '\x2', '\x2', '\x2', '\a', '\x35', 
		'\x3', '\x2', '\x2', '\x2', '\t', '\x37', '\x3', '\x2', '\x2', '\x2', 
		'\v', '\x39', '\x3', '\x2', '\x2', '\x2', '\r', ';', '\x3', '\x2', '\x2', 
		'\x2', '\xF', '=', '\x3', '\x2', '\x2', '\x2', '\x11', '?', '\x3', '\x2', 
		'\x2', '\x2', '\x13', '\x41', '\x3', '\x2', '\x2', '\x2', '\x15', '\x43', 
		'\x3', '\x2', '\x2', '\x2', '\x17', '\x46', '\x3', '\x2', '\x2', '\x2', 
		'\x19', 'I', '\x3', '\x2', '\x2', '\x2', '\x1B', 'V', '\x3', '\x2', '\x2', 
		'\x2', '\x1D', '\x64', '\x3', '\x2', '\x2', '\x2', '\x1F', '\x66', '\x3', 
		'\x2', '\x2', '\x2', '!', 'r', '\x3', '\x2', '\x2', '\x2', '#', '\x7F', 
		'\x3', '\x2', '\x2', '\x2', '%', '\x83', '\x3', '\x2', '\x2', '\x2', '\'', 
		'\x99', '\x3', '\x2', '\x2', '\x2', ')', '\x9B', '\x3', '\x2', '\x2', 
		'\x2', '+', '\x9E', '\x3', '\x2', '\x2', '\x2', '-', '\xA1', '\x3', '\x2', 
		'\x2', '\x2', '/', '\xA7', '\x3', '\x2', '\x2', '\x2', '\x31', '\x32', 
		'\a', ']', '\x2', '\x2', '\x32', '\x4', '\x3', '\x2', '\x2', '\x2', '\x33', 
		'\x34', '\a', '<', '\x2', '\x2', '\x34', '\x6', '\x3', '\x2', '\x2', '\x2', 
		'\x35', '\x36', '\a', '_', '\x2', '\x2', '\x36', '\b', '\x3', '\x2', '\x2', 
		'\x2', '\x37', '\x38', '\a', '}', '\x2', '\x2', '\x38', '\n', '\x3', '\x2', 
		'\x2', '\x2', '\x39', ':', '\a', '.', '\x2', '\x2', ':', '\f', '\x3', 
		'\x2', '\x2', '\x2', ';', '<', '\a', '\x7F', '\x2', '\x2', '<', '\xE', 
		'\x3', '\x2', '\x2', '\x2', '=', '>', '\a', '*', '\x2', '\x2', '>', '\x10', 
		'\x3', '\x2', '\x2', '\x2', '?', '@', '\a', '+', '\x2', '\x2', '@', '\x12', 
		'\x3', '\x2', '\x2', '\x2', '\x41', '\x42', '\a', '/', '\x2', '\x2', '\x42', 
		'\x14', '\x3', '\x2', '\x2', '\x2', '\x43', '\x44', '\a', '/', '\x2', 
		'\x2', '\x44', '\x45', '\a', '@', '\x2', '\x2', '\x45', '\x16', '\x3', 
		'\x2', '\x2', '\x2', '\x46', 'G', '\x5', '\x1F', '\x10', '\x2', 'G', '\x18', 
		'\x3', '\x2', '\x2', '\x2', 'H', 'J', '\t', '\x2', '\x2', '\x2', 'I', 
		'H', '\x3', '\x2', '\x2', '\x2', 'J', 'K', '\x3', '\x2', '\x2', '\x2', 
		'K', 'I', '\x3', '\x2', '\x2', '\x2', 'K', 'L', '\x3', '\x2', '\x2', '\x2', 
		'L', 'N', '\x3', '\x2', '\x2', '\x2', 'M', 'O', '\a', '\x30', '\x2', '\x2', 
		'N', 'M', '\x3', '\x2', '\x2', '\x2', 'N', 'O', '\x3', '\x2', '\x2', '\x2', 
		'O', 'S', '\x3', '\x2', '\x2', '\x2', 'P', 'R', '\t', '\x2', '\x2', '\x2', 
		'Q', 'P', '\x3', '\x2', '\x2', '\x2', 'R', 'U', '\x3', '\x2', '\x2', '\x2', 
		'S', 'Q', '\x3', '\x2', '\x2', '\x2', 'S', 'T', '\x3', '\x2', '\x2', '\x2', 
		'T', '\x1A', '\x3', '\x2', '\x2', '\x2', 'U', 'S', '\x3', '\x2', '\x2', 
		'\x2', 'V', 'W', '\a', 'p', '\x2', '\x2', 'W', 'X', '\a', 'w', '\x2', 
		'\x2', 'X', 'Y', '\a', 'n', '\x2', '\x2', 'Y', 'Z', '\a', 'n', '\x2', 
		'\x2', 'Z', '\x1C', '\x3', '\x2', '\x2', '\x2', '[', '\\', '\a', 'v', 
		'\x2', '\x2', '\\', ']', '\a', 't', '\x2', '\x2', ']', '^', '\a', 'w', 
		'\x2', '\x2', '^', '\x65', '\a', 'g', '\x2', '\x2', '_', '`', '\a', 'h', 
		'\x2', '\x2', '`', '\x61', '\a', '\x63', '\x2', '\x2', '\x61', '\x62', 
		'\a', 'n', '\x2', '\x2', '\x62', '\x63', '\a', 'u', '\x2', '\x2', '\x63', 
		'\x65', '\a', 'g', '\x2', '\x2', '\x64', '[', '\x3', '\x2', '\x2', '\x2', 
		'\x64', '_', '\x3', '\x2', '\x2', '\x2', '\x65', '\x1E', '\x3', '\x2', 
		'\x2', '\x2', '\x66', 'm', '\a', '$', '\x2', '\x2', 'g', 'l', '\n', '\x3', 
		'\x2', '\x2', 'h', 'l', '\a', ')', '\x2', '\x2', 'i', 'j', '\a', '^', 
		'\x2', '\x2', 'j', 'l', '\a', '$', '\x2', '\x2', 'k', 'g', '\x3', '\x2', 
		'\x2', '\x2', 'k', 'h', '\x3', '\x2', '\x2', '\x2', 'k', 'i', '\x3', '\x2', 
		'\x2', '\x2', 'l', 'o', '\x3', '\x2', '\x2', '\x2', 'm', 'k', '\x3', '\x2', 
		'\x2', '\x2', 'm', 'n', '\x3', '\x2', '\x2', '\x2', 'n', 'p', '\x3', '\x2', 
		'\x2', '\x2', 'o', 'm', '\x3', '\x2', '\x2', '\x2', 'p', 'q', '\a', '$', 
		'\x2', '\x2', 'q', ' ', '\x3', '\x2', '\x2', '\x2', 'r', '{', '\x5', ')', 
		'\x15', '\x2', 's', 'v', '\x5', '#', '\x12', '\x2', 't', 'v', '\a', '\x30', 
		'\x2', '\x2', 'u', 's', '\x3', '\x2', '\x2', '\x2', 'u', 't', '\x3', '\x2', 
		'\x2', '\x2', 'v', 'y', '\x3', '\x2', '\x2', '\x2', 'w', 'u', '\x3', '\x2', 
		'\x2', '\x2', 'w', 'x', '\x3', '\x2', '\x2', '\x2', 'x', 'z', '\x3', '\x2', 
		'\x2', '\x2', 'y', 'w', '\x3', '\x2', '\x2', '\x2', 'z', '|', '\x5', '#', 
		'\x12', '\x2', '{', 'w', '\x3', '\x2', '\x2', '\x2', '{', '|', '\x3', 
		'\x2', '\x2', '\x2', '|', '\"', '\x3', '\x2', '\x2', '\x2', '}', '\x80', 
		'\x5', '%', '\x13', '\x2', '~', '\x80', '\t', '\x4', '\x2', '\x2', '\x7F', 
		'}', '\x3', '\x2', '\x2', '\x2', '\x7F', '~', '\x3', '\x2', '\x2', '\x2', 
		'\x80', '$', '\x3', '\x2', '\x2', '\x2', '\x81', '\x84', '\x5', ')', '\x15', 
		'\x2', '\x82', '\x84', '\a', '\x61', '\x2', '\x2', '\x83', '\x81', '\x3', 
		'\x2', '\x2', '\x2', '\x83', '\x82', '\x3', '\x2', '\x2', '\x2', '\x84', 
		'&', '\x3', '\x2', '\x2', '\x2', '\x85', '\x86', '\a', '^', '\x2', '\x2', 
		'\x86', '\x87', '\a', 'w', '\x2', '\x2', '\x87', '\x88', '\x3', '\x2', 
		'\x2', '\x2', '\x88', '\x89', '\x5', '+', '\x16', '\x2', '\x89', '\x8A', 
		'\x5', '+', '\x16', '\x2', '\x8A', '\x8B', '\x5', '+', '\x16', '\x2', 
		'\x8B', '\x8C', '\x5', '+', '\x16', '\x2', '\x8C', '\x9A', '\x3', '\x2', 
		'\x2', '\x2', '\x8D', '\x8E', '\a', '^', '\x2', '\x2', '\x8E', '\x8F', 
		'\a', 'W', '\x2', '\x2', '\x8F', '\x90', '\x3', '\x2', '\x2', '\x2', '\x90', 
		'\x91', '\x5', '+', '\x16', '\x2', '\x91', '\x92', '\x5', '+', '\x16', 
		'\x2', '\x92', '\x93', '\x5', '+', '\x16', '\x2', '\x93', '\x94', '\x5', 
		'+', '\x16', '\x2', '\x94', '\x95', '\x5', '+', '\x16', '\x2', '\x95', 
		'\x96', '\x5', '+', '\x16', '\x2', '\x96', '\x97', '\x5', '+', '\x16', 
		'\x2', '\x97', '\x98', '\x5', '+', '\x16', '\x2', '\x98', '\x9A', '\x3', 
		'\x2', '\x2', '\x2', '\x99', '\x85', '\x3', '\x2', '\x2', '\x2', '\x99', 
		'\x8D', '\x3', '\x2', '\x2', '\x2', '\x9A', '(', '\x3', '\x2', '\x2', 
		'\x2', '\x9B', '\x9C', '\t', '\x5', '\x2', '\x2', '\x9C', '*', '\x3', 
		'\x2', '\x2', '\x2', '\x9D', '\x9F', '\t', '\x6', '\x2', '\x2', '\x9E', 
		'\x9D', '\x3', '\x2', '\x2', '\x2', '\x9F', ',', '\x3', '\x2', '\x2', 
		'\x2', '\xA0', '\xA2', '\t', '\a', '\x2', '\x2', '\xA1', '\xA0', '\x3', 
		'\x2', '\x2', '\x2', '\xA2', '\xA3', '\x3', '\x2', '\x2', '\x2', '\xA3', 
		'\xA1', '\x3', '\x2', '\x2', '\x2', '\xA3', '\xA4', '\x3', '\x2', '\x2', 
		'\x2', '\xA4', '\xA5', '\x3', '\x2', '\x2', '\x2', '\xA5', '\xA6', '\b', 
		'\x17', '\x2', '\x2', '\xA6', '.', '\x3', '\x2', '\x2', '\x2', '\xA7', 
		'\xA8', '\t', '\b', '\x2', '\x2', '\xA8', '\x30', '\x3', '\x2', '\x2', 
		'\x2', '\x12', '\x2', 'K', 'N', 'S', '\x64', 'k', 'm', 'u', 'w', '{', 
		'\x7F', '\x83', '\x99', '\x9E', '\xA1', '\xA3', '\x3', '\b', '\x2', '\x2',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.9.3
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from ConversionGrammar.g4 by ANTLR 4.9.3

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace CshPlgr.Lib.Converter.Generated {
using System;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.9.3")]
[System.CLSCompliant(false)]
public partial class ConversionGrammarLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		LARGE_ALPHA=1, LARGE_EPSILON=2, LARGE_ETA=3, LARGE_IOTA=4, LARGE_OMICRON=5, 
		LARGE_UPSILON=6, LARGE_OMEGA=7, LARGE_BETA=8, LARGE_GAMMA=9, LARGE_DELTA=10, 
		LARGE_ZETA=11, LARGE_KAPPA=12, LARGE_LAMBDA=13, LARGE_MU=14, LARGE_NU=15, 
		LARGE_XI=16, LARGE_PI=17, LARGE_RHO=18, LARGE_SIGMA=19, LARGE_TAU=20, 
		SMALL_ALPHA=21, SMALL_EPSILON=22, SMALL_ETA=23, SMALL_IOTA=24, SMALL_OMICRON=25, 
		SMALL_UPSILON=26, SMALL_OMEGA=27, SMALL_BETA=28, SMALL_GAMMA=29, SMALL_DELTA=30, 
		SMALL_ZETA=31, SMALL_KAPPA=32, SMALL_LAMBDA=33, SMALL_MU=34, SMALL_NU=35, 
		SMALL_XI=36, SMALL_PI=37, SMALL_RHO=38, SMALL_SIGMA=39, SMALL_TAU=40, 
		COMMA=41, SEMICORON=42, PERIOD=43, QUESTION=44, APOSTROPH=45, LGUILLEMET=46, 
		RGUILLEMET=47, EMDASH=48, SPACE=49, NEWLINE=50, ANYCHAR=51;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"LARGE_ALPHA", "LARGE_EPSILON", "LARGE_ETA", "LARGE_IOTA", "LARGE_OMICRON", 
		"LARGE_UPSILON", "LARGE_OMEGA", "LARGE_BETA", "LARGE_GAMMA", "LARGE_DELTA", 
		"LARGE_ZETA", "LARGE_KAPPA", "LARGE_LAMBDA", "LARGE_MU", "LARGE_NU", "LARGE_XI", 
		"LARGE_PI", "LARGE_RHO", "LARGE_SIGMA", "LARGE_TAU", "SMALL_ALPHA", "SMALL_EPSILON", 
		"SMALL_ETA", "SMALL_IOTA", "SMALL_OMICRON", "SMALL_UPSILON", "SMALL_OMEGA", 
		"SMALL_BETA", "SMALL_GAMMA", "SMALL_DELTA", "SMALL_ZETA", "SMALL_KAPPA", 
		"SMALL_LAMBDA", "SMALL_MU", "SMALL_NU", "SMALL_XI", "SMALL_PI", "SMALL_RHO", 
		"SMALL_SIGMA", "SMALL_TAU", "COMMA", "SEMICORON", "PERIOD", "QUESTION", 
		"APOSTROPH", "LGUILLEMET", "RGUILLEMET", "EMDASH", "SPACE", "NEWLINE", 
		"ANYCHAR"
	};


	public ConversionGrammarLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public ConversionGrammarLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, null, null, null, null, null, null, null, "'B'", "'G'", "'D'", "'Z'", 
		null, "'L'", "'M'", "'N'", "'X'", null, null, "'S'", null, null, null, 
		null, null, null, null, null, "'b'", "'g'", "'d'", "'z'", null, "'l'", 
		"'m'", "'n'", "'x'", null, null, null, null, "','", "';'", "'.'", "'?'", 
		"''''", "'<<'", "'>>'", "'--'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "LARGE_ALPHA", "LARGE_EPSILON", "LARGE_ETA", "LARGE_IOTA", "LARGE_OMICRON", 
		"LARGE_UPSILON", "LARGE_OMEGA", "LARGE_BETA", "LARGE_GAMMA", "LARGE_DELTA", 
		"LARGE_ZETA", "LARGE_KAPPA", "LARGE_LAMBDA", "LARGE_MU", "LARGE_NU", "LARGE_XI", 
		"LARGE_PI", "LARGE_RHO", "LARGE_SIGMA", "LARGE_TAU", "SMALL_ALPHA", "SMALL_EPSILON", 
		"SMALL_ETA", "SMALL_IOTA", "SMALL_OMICRON", "SMALL_UPSILON", "SMALL_OMEGA", 
		"SMALL_BETA", "SMALL_GAMMA", "SMALL_DELTA", "SMALL_ZETA", "SMALL_KAPPA", 
		"SMALL_LAMBDA", "SMALL_MU", "SMALL_NU", "SMALL_XI", "SMALL_PI", "SMALL_RHO", 
		"SMALL_SIGMA", "SMALL_TAU", "COMMA", "SEMICORON", "PERIOD", "QUESTION", 
		"APOSTROPH", "LGUILLEMET", "RGUILLEMET", "EMDASH", "SPACE", "NEWLINE", 
		"ANYCHAR"
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

	public override string GrammarFileName { get { return "ConversionGrammar.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static ConversionGrammarLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x2', '\x35', '\x153', '\b', '\x1', '\x4', '\x2', '\t', '\x2', 
		'\x4', '\x3', '\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', 
		'\x5', '\x4', '\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', '\x4', '\b', 
		'\t', '\b', '\x4', '\t', '\t', '\t', '\x4', '\n', '\t', '\n', '\x4', '\v', 
		'\t', '\v', '\x4', '\f', '\t', '\f', '\x4', '\r', '\t', '\r', '\x4', '\xE', 
		'\t', '\xE', '\x4', '\xF', '\t', '\xF', '\x4', '\x10', '\t', '\x10', '\x4', 
		'\x11', '\t', '\x11', '\x4', '\x12', '\t', '\x12', '\x4', '\x13', '\t', 
		'\x13', '\x4', '\x14', '\t', '\x14', '\x4', '\x15', '\t', '\x15', '\x4', 
		'\x16', '\t', '\x16', '\x4', '\x17', '\t', '\x17', '\x4', '\x18', '\t', 
		'\x18', '\x4', '\x19', '\t', '\x19', '\x4', '\x1A', '\t', '\x1A', '\x4', 
		'\x1B', '\t', '\x1B', '\x4', '\x1C', '\t', '\x1C', '\x4', '\x1D', '\t', 
		'\x1D', '\x4', '\x1E', '\t', '\x1E', '\x4', '\x1F', '\t', '\x1F', '\x4', 
		' ', '\t', ' ', '\x4', '!', '\t', '!', '\x4', '\"', '\t', '\"', '\x4', 
		'#', '\t', '#', '\x4', '$', '\t', '$', '\x4', '%', '\t', '%', '\x4', '&', 
		'\t', '&', '\x4', '\'', '\t', '\'', '\x4', '(', '\t', '(', '\x4', ')', 
		'\t', ')', '\x4', '*', '\t', '*', '\x4', '+', '\t', '+', '\x4', ',', '\t', 
		',', '\x4', '-', '\t', '-', '\x4', '.', '\t', '.', '\x4', '/', '\t', '/', 
		'\x4', '\x30', '\t', '\x30', '\x4', '\x31', '\t', '\x31', '\x4', '\x32', 
		'\t', '\x32', '\x4', '\x33', '\t', '\x33', '\x4', '\x34', '\t', '\x34', 
		'\x3', '\x2', '\x5', '\x2', 'k', '\n', '\x2', '\x3', '\x2', '\x5', '\x2', 
		'n', '\n', '\x2', '\x3', '\x2', '\x3', '\x2', '\x5', '\x2', 'r', '\n', 
		'\x2', '\x3', '\x3', '\x5', '\x3', 'u', '\n', '\x3', '\x3', '\x3', '\x5', 
		'\x3', 'x', '\n', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x4', '\x5', 
		'\x4', '}', '\n', '\x4', '\x3', '\x4', '\x5', '\x4', '\x80', '\n', '\x4', 
		'\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x5', '\x4', 
		'\x86', '\n', '\x4', '\x3', '\x5', '\x5', '\x5', '\x89', '\n', '\x5', 
		'\x3', '\x5', '\x5', '\x5', '\x8C', '\n', '\x5', '\x3', '\x5', '\x3', 
		'\x5', '\x3', '\x6', '\x5', '\x6', '\x91', '\n', '\x6', '\x3', '\x6', 
		'\x5', '\x6', '\x94', '\n', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', 
		'\a', '\x5', '\a', '\x99', '\n', '\a', '\x3', '\a', '\x5', '\a', '\x9C', 
		'\n', '\a', '\x3', '\a', '\x3', '\a', '\x3', '\b', '\x5', '\b', '\xA1', 
		'\n', '\b', '\x3', '\b', '\x5', '\b', '\xA4', '\n', '\b', '\x3', '\b', 
		'\x3', '\b', '\x3', '\b', '\x3', '\b', '\x5', '\b', '\xAA', '\n', '\b', 
		'\x3', '\t', '\x3', '\t', '\x3', '\n', '\x3', '\n', '\x3', '\v', '\x3', 
		'\v', '\x3', '\f', '\x3', '\f', '\x3', '\r', '\x3', '\r', '\x5', '\r', 
		'\xB6', '\n', '\r', '\x3', '\xE', '\x3', '\xE', '\x3', '\xF', '\x3', '\xF', 
		'\x3', '\x10', '\x3', '\x10', '\x3', '\x11', '\x3', '\x11', '\x3', '\x12', 
		'\x3', '\x12', '\x5', '\x12', '\xC2', '\n', '\x12', '\x3', '\x13', '\x5', 
		'\x13', '\xC5', '\n', '\x13', '\x3', '\x13', '\x3', '\x13', '\x3', '\x14', 
		'\x3', '\x14', '\x3', '\x15', '\x3', '\x15', '\x5', '\x15', '\xCD', '\n', 
		'\x15', '\x3', '\x16', '\x5', '\x16', '\xD0', '\n', '\x16', '\x3', '\x16', 
		'\x5', '\x16', '\xD3', '\n', '\x16', '\x3', '\x16', '\x3', '\x16', '\x5', 
		'\x16', '\xD7', '\n', '\x16', '\x3', '\x17', '\x5', '\x17', '\xDA', '\n', 
		'\x17', '\x3', '\x17', '\x5', '\x17', '\xDD', '\n', '\x17', '\x3', '\x17', 
		'\x3', '\x17', '\x3', '\x18', '\x5', '\x18', '\xE2', '\n', '\x18', '\x3', 
		'\x18', '\x5', '\x18', '\xE5', '\n', '\x18', '\x3', '\x18', '\x3', '\x18', 
		'\x3', '\x18', '\x3', '\x18', '\x5', '\x18', '\xEB', '\n', '\x18', '\x3', 
		'\x19', '\x5', '\x19', '\xEE', '\n', '\x19', '\x3', '\x19', '\x5', '\x19', 
		'\xF1', '\n', '\x19', '\x3', '\x19', '\x3', '\x19', '\x3', '\x1A', '\x5', 
		'\x1A', '\xF6', '\n', '\x1A', '\x3', '\x1A', '\x5', '\x1A', '\xF9', '\n', 
		'\x1A', '\x3', '\x1A', '\x3', '\x1A', '\x3', '\x1B', '\x5', '\x1B', '\xFE', 
		'\n', '\x1B', '\x3', '\x1B', '\x5', '\x1B', '\x101', '\n', '\x1B', '\x3', 
		'\x1B', '\x3', '\x1B', '\x3', '\x1C', '\x5', '\x1C', '\x106', '\n', '\x1C', 
		'\x3', '\x1C', '\x5', '\x1C', '\x109', '\n', '\x1C', '\x3', '\x1C', '\x3', 
		'\x1C', '\x3', '\x1C', '\x3', '\x1C', '\x5', '\x1C', '\x10F', '\n', '\x1C', 
		'\x3', '\x1D', '\x3', '\x1D', '\x3', '\x1E', '\x3', '\x1E', '\x3', '\x1F', 
		'\x3', '\x1F', '\x3', ' ', '\x3', ' ', '\x3', '!', '\x3', '!', '\x5', 
		'!', '\x11B', '\n', '!', '\x3', '\"', '\x3', '\"', '\x3', '#', '\x3', 
		'#', '\x3', '$', '\x3', '$', '\x3', '%', '\x3', '%', '\x3', '&', '\x3', 
		'&', '\x5', '&', '\x127', '\n', '&', '\x3', '\'', '\x5', '\'', '\x12A', 
		'\n', '\'', '\x3', '\'', '\x3', '\'', '\x3', '(', '\x3', '(', '\x3', ')', 
		'\x3', ')', '\x5', ')', '\x132', '\n', ')', '\x3', '*', '\x3', '*', '\x3', 
		'+', '\x3', '+', '\x3', ',', '\x3', ',', '\x3', '-', '\x3', '-', '\x3', 
		'.', '\x3', '.', '\x3', '.', '\x3', '/', '\x3', '/', '\x3', '/', '\x3', 
		'\x30', '\x3', '\x30', '\x3', '\x30', '\x3', '\x31', '\x3', '\x31', '\x3', 
		'\x31', '\x3', '\x32', '\x6', '\x32', '\x149', '\n', '\x32', '\r', '\x32', 
		'\xE', '\x32', '\x14A', '\x3', '\x33', '\x5', '\x33', '\x14E', '\n', '\x33', 
		'\x3', '\x33', '\x3', '\x33', '\x3', '\x34', '\x3', '\x34', '\x2', '\x2', 
		'\x35', '\x3', '\x3', '\x5', '\x4', '\a', '\x5', '\t', '\x6', '\v', '\a', 
		'\r', '\b', '\xF', '\t', '\x11', '\n', '\x13', '\v', '\x15', '\f', '\x17', 
		'\r', '\x19', '\xE', '\x1B', '\xF', '\x1D', '\x10', '\x1F', '\x11', '!', 
		'\x12', '#', '\x13', '%', '\x14', '\'', '\x15', ')', '\x16', '+', '\x17', 
		'-', '\x18', '/', '\x19', '\x31', '\x1A', '\x33', '\x1B', '\x35', '\x1C', 
		'\x37', '\x1D', '\x39', '\x1E', ';', '\x1F', '=', ' ', '?', '!', '\x41', 
		'\"', '\x43', '#', '\x45', '$', 'G', '%', 'I', '&', 'K', '\'', 'M', '(', 
		'O', ')', 'Q', '*', 'S', '+', 'U', ',', 'W', '-', 'Y', '.', '[', '/', 
		']', '\x30', '_', '\x31', '\x61', '\x32', '\x63', '\x33', '\x65', '\x34', 
		'g', '\x35', '\x3', '\x2', '\v', '\x4', '\x2', '>', '>', '@', '@', '\x5', 
		'\x2', ')', ')', '\x62', '\x62', '\x80', '\x80', '\x4', '\x2', ')', ')', 
		'\x62', '\x62', '\x5', '\x2', '$', '$', '>', '>', '@', '@', '\x4', '\x2', 
		'W', 'W', '[', '[', '\x4', '\x2', 'j', 'j', 'u', 'u', '\x4', '\x2', 'w', 
		'w', '{', '{', '\x4', '\x2', '\x65', '\x65', 'u', 'u', '\x4', '\x2', '\v', 
		'\v', '\"', '\"', '\x2', '\x17E', '\x2', '\x3', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\x5', '\x3', '\x2', '\x2', '\x2', '\x2', '\a', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\t', '\x3', '\x2', '\x2', '\x2', '\x2', '\v', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\r', '\x3', '\x2', '\x2', '\x2', '\x2', '\xF', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\x11', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\x13', '\x3', '\x2', '\x2', '\x2', '\x2', '\x15', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\x17', '\x3', '\x2', '\x2', '\x2', '\x2', '\x19', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\x1B', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\x1D', '\x3', '\x2', '\x2', '\x2', '\x2', '\x1F', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '!', '\x3', '\x2', '\x2', '\x2', '\x2', '#', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '%', '\x3', '\x2', '\x2', '\x2', '\x2', '\'', '\x3', 
		'\x2', '\x2', '\x2', '\x2', ')', '\x3', '\x2', '\x2', '\x2', '\x2', '+', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '-', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'/', '\x3', '\x2', '\x2', '\x2', '\x2', '\x31', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\x33', '\x3', '\x2', '\x2', '\x2', '\x2', '\x35', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\x37', '\x3', '\x2', '\x2', '\x2', '\x2', '\x39', 
		'\x3', '\x2', '\x2', '\x2', '\x2', ';', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'=', '\x3', '\x2', '\x2', '\x2', '\x2', '?', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\x41', '\x3', '\x2', '\x2', '\x2', '\x2', '\x43', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\x45', '\x3', '\x2', '\x2', '\x2', '\x2', 'G', '\x3', 
		'\x2', '\x2', '\x2', '\x2', 'I', '\x3', '\x2', '\x2', '\x2', '\x2', 'K', 
		'\x3', '\x2', '\x2', '\x2', '\x2', 'M', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'O', '\x3', '\x2', '\x2', '\x2', '\x2', 'Q', '\x3', '\x2', '\x2', '\x2', 
		'\x2', 'S', '\x3', '\x2', '\x2', '\x2', '\x2', 'U', '\x3', '\x2', '\x2', 
		'\x2', '\x2', 'W', '\x3', '\x2', '\x2', '\x2', '\x2', 'Y', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '[', '\x3', '\x2', '\x2', '\x2', '\x2', ']', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '_', '\x3', '\x2', '\x2', '\x2', '\x2', '\x61', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\x63', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\x65', '\x3', '\x2', '\x2', '\x2', '\x2', 'g', '\x3', '\x2', '\x2', 
		'\x2', '\x3', 'j', '\x3', '\x2', '\x2', '\x2', '\x5', 't', '\x3', '\x2', 
		'\x2', '\x2', '\a', '|', '\x3', '\x2', '\x2', '\x2', '\t', '\x88', '\x3', 
		'\x2', '\x2', '\x2', '\v', '\x90', '\x3', '\x2', '\x2', '\x2', '\r', '\x98', 
		'\x3', '\x2', '\x2', '\x2', '\xF', '\xA0', '\x3', '\x2', '\x2', '\x2', 
		'\x11', '\xAB', '\x3', '\x2', '\x2', '\x2', '\x13', '\xAD', '\x3', '\x2', 
		'\x2', '\x2', '\x15', '\xAF', '\x3', '\x2', '\x2', '\x2', '\x17', '\xB1', 
		'\x3', '\x2', '\x2', '\x2', '\x19', '\xB3', '\x3', '\x2', '\x2', '\x2', 
		'\x1B', '\xB7', '\x3', '\x2', '\x2', '\x2', '\x1D', '\xB9', '\x3', '\x2', 
		'\x2', '\x2', '\x1F', '\xBB', '\x3', '\x2', '\x2', '\x2', '!', '\xBD', 
		'\x3', '\x2', '\x2', '\x2', '#', '\xBF', '\x3', '\x2', '\x2', '\x2', '%', 
		'\xC4', '\x3', '\x2', '\x2', '\x2', '\'', '\xC8', '\x3', '\x2', '\x2', 
		'\x2', ')', '\xCA', '\x3', '\x2', '\x2', '\x2', '+', '\xCF', '\x3', '\x2', 
		'\x2', '\x2', '-', '\xD9', '\x3', '\x2', '\x2', '\x2', '/', '\xE1', '\x3', 
		'\x2', '\x2', '\x2', '\x31', '\xED', '\x3', '\x2', '\x2', '\x2', '\x33', 
		'\xF5', '\x3', '\x2', '\x2', '\x2', '\x35', '\xFD', '\x3', '\x2', '\x2', 
		'\x2', '\x37', '\x105', '\x3', '\x2', '\x2', '\x2', '\x39', '\x110', '\x3', 
		'\x2', '\x2', '\x2', ';', '\x112', '\x3', '\x2', '\x2', '\x2', '=', '\x114', 
		'\x3', '\x2', '\x2', '\x2', '?', '\x116', '\x3', '\x2', '\x2', '\x2', 
		'\x41', '\x118', '\x3', '\x2', '\x2', '\x2', '\x43', '\x11C', '\x3', '\x2', 
		'\x2', '\x2', '\x45', '\x11E', '\x3', '\x2', '\x2', '\x2', 'G', '\x120', 
		'\x3', '\x2', '\x2', '\x2', 'I', '\x122', '\x3', '\x2', '\x2', '\x2', 
		'K', '\x124', '\x3', '\x2', '\x2', '\x2', 'M', '\x129', '\x3', '\x2', 
		'\x2', '\x2', 'O', '\x12D', '\x3', '\x2', '\x2', '\x2', 'Q', '\x12F', 
		'\x3', '\x2', '\x2', '\x2', 'S', '\x133', '\x3', '\x2', '\x2', '\x2', 
		'U', '\x135', '\x3', '\x2', '\x2', '\x2', 'W', '\x137', '\x3', '\x2', 
		'\x2', '\x2', 'Y', '\x139', '\x3', '\x2', '\x2', '\x2', '[', '\x13B', 
		'\x3', '\x2', '\x2', '\x2', ']', '\x13E', '\x3', '\x2', '\x2', '\x2', 
		'_', '\x141', '\x3', '\x2', '\x2', '\x2', '\x61', '\x144', '\x3', '\x2', 
		'\x2', '\x2', '\x63', '\x148', '\x3', '\x2', '\x2', '\x2', '\x65', '\x14D', 
		'\x3', '\x2', '\x2', '\x2', 'g', '\x151', '\x3', '\x2', '\x2', '\x2', 
		'i', 'k', '\t', '\x2', '\x2', '\x2', 'j', 'i', '\x3', '\x2', '\x2', '\x2', 
		'j', 'k', '\x3', '\x2', '\x2', '\x2', 'k', 'm', '\x3', '\x2', '\x2', '\x2', 
		'l', 'n', '\t', '\x3', '\x2', '\x2', 'm', 'l', '\x3', '\x2', '\x2', '\x2', 
		'm', 'n', '\x3', '\x2', '\x2', '\x2', 'n', 'o', '\x3', '\x2', '\x2', '\x2', 
		'o', 'q', '\a', '\x43', '\x2', '\x2', 'p', 'r', '\a', '~', '\x2', '\x2', 
		'q', 'p', '\x3', '\x2', '\x2', '\x2', 'q', 'r', '\x3', '\x2', '\x2', '\x2', 
		'r', '\x4', '\x3', '\x2', '\x2', '\x2', 's', 'u', '\t', '\x2', '\x2', 
		'\x2', 't', 's', '\x3', '\x2', '\x2', '\x2', 't', 'u', '\x3', '\x2', '\x2', 
		'\x2', 'u', 'w', '\x3', '\x2', '\x2', '\x2', 'v', 'x', '\t', '\x4', '\x2', 
		'\x2', 'w', 'v', '\x3', '\x2', '\x2', '\x2', 'w', 'x', '\x3', '\x2', '\x2', 
		'\x2', 'x', 'y', '\x3', '\x2', '\x2', '\x2', 'y', 'z', '\a', 'G', '\x2', 
		'\x2', 'z', '\x6', '\x3', '\x2', '\x2', '\x2', '{', '}', '\t', '\x2', 
		'\x2', '\x2', '|', '{', '\x3', '\x2', '\x2', '\x2', '|', '}', '\x3', '\x2', 
		'\x2', '\x2', '}', '\x7F', '\x3', '\x2', '\x2', '\x2', '~', '\x80', '\t', 
		'\x3', '\x2', '\x2', '\x7F', '~', '\x3', '\x2', '\x2', '\x2', '\x7F', 
		'\x80', '\x3', '\x2', '\x2', '\x2', '\x80', '\x81', '\x3', '\x2', '\x2', 
		'\x2', '\x81', '\x82', '\a', '`', '\x2', '\x2', '\x82', '\x83', '\a', 
		'G', '\x2', '\x2', '\x83', '\x85', '\x3', '\x2', '\x2', '\x2', '\x84', 
		'\x86', '\a', '~', '\x2', '\x2', '\x85', '\x84', '\x3', '\x2', '\x2', 
		'\x2', '\x85', '\x86', '\x3', '\x2', '\x2', '\x2', '\x86', '\b', '\x3', 
		'\x2', '\x2', '\x2', '\x87', '\x89', '\t', '\x5', '\x2', '\x2', '\x88', 
		'\x87', '\x3', '\x2', '\x2', '\x2', '\x88', '\x89', '\x3', '\x2', '\x2', 
		'\x2', '\x89', '\x8B', '\x3', '\x2', '\x2', '\x2', '\x8A', '\x8C', '\t', 
		'\x3', '\x2', '\x2', '\x8B', '\x8A', '\x3', '\x2', '\x2', '\x2', '\x8B', 
		'\x8C', '\x3', '\x2', '\x2', '\x2', '\x8C', '\x8D', '\x3', '\x2', '\x2', 
		'\x2', '\x8D', '\x8E', '\a', 'K', '\x2', '\x2', '\x8E', '\n', '\x3', '\x2', 
		'\x2', '\x2', '\x8F', '\x91', '\t', '\x2', '\x2', '\x2', '\x90', '\x8F', 
		'\x3', '\x2', '\x2', '\x2', '\x90', '\x91', '\x3', '\x2', '\x2', '\x2', 
		'\x91', '\x93', '\x3', '\x2', '\x2', '\x2', '\x92', '\x94', '\t', '\x4', 
		'\x2', '\x2', '\x93', '\x92', '\x3', '\x2', '\x2', '\x2', '\x93', '\x94', 
		'\x3', '\x2', '\x2', '\x2', '\x94', '\x95', '\x3', '\x2', '\x2', '\x2', 
		'\x95', '\x96', '\a', 'Q', '\x2', '\x2', '\x96', '\f', '\x3', '\x2', '\x2', 
		'\x2', '\x97', '\x99', '\t', '\x5', '\x2', '\x2', '\x98', '\x97', '\x3', 
		'\x2', '\x2', '\x2', '\x98', '\x99', '\x3', '\x2', '\x2', '\x2', '\x99', 
		'\x9B', '\x3', '\x2', '\x2', '\x2', '\x9A', '\x9C', '\t', '\x3', '\x2', 
		'\x2', '\x9B', '\x9A', '\x3', '\x2', '\x2', '\x2', '\x9B', '\x9C', '\x3', 
		'\x2', '\x2', '\x2', '\x9C', '\x9D', '\x3', '\x2', '\x2', '\x2', '\x9D', 
		'\x9E', '\t', '\x6', '\x2', '\x2', '\x9E', '\xE', '\x3', '\x2', '\x2', 
		'\x2', '\x9F', '\xA1', '\t', '\x2', '\x2', '\x2', '\xA0', '\x9F', '\x3', 
		'\x2', '\x2', '\x2', '\xA0', '\xA1', '\x3', '\x2', '\x2', '\x2', '\xA1', 
		'\xA3', '\x3', '\x2', '\x2', '\x2', '\xA2', '\xA4', '\t', '\x3', '\x2', 
		'\x2', '\xA3', '\xA2', '\x3', '\x2', '\x2', '\x2', '\xA3', '\xA4', '\x3', 
		'\x2', '\x2', '\x2', '\xA4', '\xA5', '\x3', '\x2', '\x2', '\x2', '\xA5', 
		'\xA6', '\a', '`', '\x2', '\x2', '\xA6', '\xA7', '\a', 'Q', '\x2', '\x2', 
		'\xA7', '\xA9', '\x3', '\x2', '\x2', '\x2', '\xA8', '\xAA', '\a', '~', 
		'\x2', '\x2', '\xA9', '\xA8', '\x3', '\x2', '\x2', '\x2', '\xA9', '\xAA', 
		'\x3', '\x2', '\x2', '\x2', '\xAA', '\x10', '\x3', '\x2', '\x2', '\x2', 
		'\xAB', '\xAC', '\a', '\x44', '\x2', '\x2', '\xAC', '\x12', '\x3', '\x2', 
		'\x2', '\x2', '\xAD', '\xAE', '\a', 'I', '\x2', '\x2', '\xAE', '\x14', 
		'\x3', '\x2', '\x2', '\x2', '\xAF', '\xB0', '\a', '\x46', '\x2', '\x2', 
		'\xB0', '\x16', '\x3', '\x2', '\x2', '\x2', '\xB1', '\xB2', '\a', '\\', 
		'\x2', '\x2', '\xB2', '\x18', '\x3', '\x2', '\x2', '\x2', '\xB3', '\xB5', 
		'\a', 'M', '\x2', '\x2', '\xB4', '\xB6', '\a', 'j', '\x2', '\x2', '\xB5', 
		'\xB4', '\x3', '\x2', '\x2', '\x2', '\xB5', '\xB6', '\x3', '\x2', '\x2', 
		'\x2', '\xB6', '\x1A', '\x3', '\x2', '\x2', '\x2', '\xB7', '\xB8', '\a', 
		'N', '\x2', '\x2', '\xB8', '\x1C', '\x3', '\x2', '\x2', '\x2', '\xB9', 
		'\xBA', '\a', 'O', '\x2', '\x2', '\xBA', '\x1E', '\x3', '\x2', '\x2', 
		'\x2', '\xBB', '\xBC', '\a', 'P', '\x2', '\x2', '\xBC', ' ', '\x3', '\x2', 
		'\x2', '\x2', '\xBD', '\xBE', '\a', 'Z', '\x2', '\x2', '\xBE', '\"', '\x3', 
		'\x2', '\x2', '\x2', '\xBF', '\xC1', '\a', 'R', '\x2', '\x2', '\xC0', 
		'\xC2', '\t', '\a', '\x2', '\x2', '\xC1', '\xC0', '\x3', '\x2', '\x2', 
		'\x2', '\xC1', '\xC2', '\x3', '\x2', '\x2', '\x2', '\xC2', '$', '\x3', 
		'\x2', '\x2', '\x2', '\xC3', '\xC5', '\a', '>', '\x2', '\x2', '\xC4', 
		'\xC3', '\x3', '\x2', '\x2', '\x2', '\xC4', '\xC5', '\x3', '\x2', '\x2', 
		'\x2', '\xC5', '\xC6', '\x3', '\x2', '\x2', '\x2', '\xC6', '\xC7', '\a', 
		'T', '\x2', '\x2', '\xC7', '&', '\x3', '\x2', '\x2', '\x2', '\xC8', '\xC9', 
		'\a', 'U', '\x2', '\x2', '\xC9', '(', '\x3', '\x2', '\x2', '\x2', '\xCA', 
		'\xCC', '\a', 'V', '\x2', '\x2', '\xCB', '\xCD', '\a', 'j', '\x2', '\x2', 
		'\xCC', '\xCB', '\x3', '\x2', '\x2', '\x2', '\xCC', '\xCD', '\x3', '\x2', 
		'\x2', '\x2', '\xCD', '*', '\x3', '\x2', '\x2', '\x2', '\xCE', '\xD0', 
		'\t', '\x2', '\x2', '\x2', '\xCF', '\xCE', '\x3', '\x2', '\x2', '\x2', 
		'\xCF', '\xD0', '\x3', '\x2', '\x2', '\x2', '\xD0', '\xD2', '\x3', '\x2', 
		'\x2', '\x2', '\xD1', '\xD3', '\t', '\x3', '\x2', '\x2', '\xD2', '\xD1', 
		'\x3', '\x2', '\x2', '\x2', '\xD2', '\xD3', '\x3', '\x2', '\x2', '\x2', 
		'\xD3', '\xD4', '\x3', '\x2', '\x2', '\x2', '\xD4', '\xD6', '\a', '\x63', 
		'\x2', '\x2', '\xD5', '\xD7', '\a', '~', '\x2', '\x2', '\xD6', '\xD5', 
		'\x3', '\x2', '\x2', '\x2', '\xD6', '\xD7', '\x3', '\x2', '\x2', '\x2', 
		'\xD7', ',', '\x3', '\x2', '\x2', '\x2', '\xD8', '\xDA', '\t', '\x2', 
		'\x2', '\x2', '\xD9', '\xD8', '\x3', '\x2', '\x2', '\x2', '\xD9', '\xDA', 
		'\x3', '\x2', '\x2', '\x2', '\xDA', '\xDC', '\x3', '\x2', '\x2', '\x2', 
		'\xDB', '\xDD', '\t', '\x4', '\x2', '\x2', '\xDC', '\xDB', '\x3', '\x2', 
		'\x2', '\x2', '\xDC', '\xDD', '\x3', '\x2', '\x2', '\x2', '\xDD', '\xDE', 
		'\x3', '\x2', '\x2', '\x2', '\xDE', '\xDF', '\a', 'g', '\x2', '\x2', '\xDF', 
		'.', '\x3', '\x2', '\x2', '\x2', '\xE0', '\xE2', '\t', '\x2', '\x2', '\x2', 
		'\xE1', '\xE0', '\x3', '\x2', '\x2', '\x2', '\xE1', '\xE2', '\x3', '\x2', 
		'\x2', '\x2', '\xE2', '\xE4', '\x3', '\x2', '\x2', '\x2', '\xE3', '\xE5', 
		'\t', '\x3', '\x2', '\x2', '\xE4', '\xE3', '\x3', '\x2', '\x2', '\x2', 
		'\xE4', '\xE5', '\x3', '\x2', '\x2', '\x2', '\xE5', '\xE6', '\x3', '\x2', 
		'\x2', '\x2', '\xE6', '\xE7', '\a', '`', '\x2', '\x2', '\xE7', '\xE8', 
		'\a', 'g', '\x2', '\x2', '\xE8', '\xEA', '\x3', '\x2', '\x2', '\x2', '\xE9', 
		'\xEB', '\a', '~', '\x2', '\x2', '\xEA', '\xE9', '\x3', '\x2', '\x2', 
		'\x2', '\xEA', '\xEB', '\x3', '\x2', '\x2', '\x2', '\xEB', '\x30', '\x3', 
		'\x2', '\x2', '\x2', '\xEC', '\xEE', '\t', '\x5', '\x2', '\x2', '\xED', 
		'\xEC', '\x3', '\x2', '\x2', '\x2', '\xED', '\xEE', '\x3', '\x2', '\x2', 
		'\x2', '\xEE', '\xF0', '\x3', '\x2', '\x2', '\x2', '\xEF', '\xF1', '\t', 
		'\x3', '\x2', '\x2', '\xF0', '\xEF', '\x3', '\x2', '\x2', '\x2', '\xF0', 
		'\xF1', '\x3', '\x2', '\x2', '\x2', '\xF1', '\xF2', '\x3', '\x2', '\x2', 
		'\x2', '\xF2', '\xF3', '\a', 'k', '\x2', '\x2', '\xF3', '\x32', '\x3', 
		'\x2', '\x2', '\x2', '\xF4', '\xF6', '\t', '\x2', '\x2', '\x2', '\xF5', 
		'\xF4', '\x3', '\x2', '\x2', '\x2', '\xF5', '\xF6', '\x3', '\x2', '\x2', 
		'\x2', '\xF6', '\xF8', '\x3', '\x2', '\x2', '\x2', '\xF7', '\xF9', '\t', 
		'\x4', '\x2', '\x2', '\xF8', '\xF7', '\x3', '\x2', '\x2', '\x2', '\xF8', 
		'\xF9', '\x3', '\x2', '\x2', '\x2', '\xF9', '\xFA', '\x3', '\x2', '\x2', 
		'\x2', '\xFA', '\xFB', '\a', 'q', '\x2', '\x2', '\xFB', '\x34', '\x3', 
		'\x2', '\x2', '\x2', '\xFC', '\xFE', '\t', '\x5', '\x2', '\x2', '\xFD', 
		'\xFC', '\x3', '\x2', '\x2', '\x2', '\xFD', '\xFE', '\x3', '\x2', '\x2', 
		'\x2', '\xFE', '\x100', '\x3', '\x2', '\x2', '\x2', '\xFF', '\x101', '\t', 
		'\x3', '\x2', '\x2', '\x100', '\xFF', '\x3', '\x2', '\x2', '\x2', '\x100', 
		'\x101', '\x3', '\x2', '\x2', '\x2', '\x101', '\x102', '\x3', '\x2', '\x2', 
		'\x2', '\x102', '\x103', '\t', '\b', '\x2', '\x2', '\x103', '\x36', '\x3', 
		'\x2', '\x2', '\x2', '\x104', '\x106', '\t', '\x2', '\x2', '\x2', '\x105', 
		'\x104', '\x3', '\x2', '\x2', '\x2', '\x105', '\x106', '\x3', '\x2', '\x2', 
		'\x2', '\x106', '\x108', '\x3', '\x2', '\x2', '\x2', '\x107', '\x109', 
		'\t', '\x3', '\x2', '\x2', '\x108', '\x107', '\x3', '\x2', '\x2', '\x2', 
		'\x108', '\x109', '\x3', '\x2', '\x2', '\x2', '\x109', '\x10A', '\x3', 
		'\x2', '\x2', '\x2', '\x10A', '\x10B', '\a', '`', '\x2', '\x2', '\x10B', 
		'\x10C', '\a', 'q', '\x2', '\x2', '\x10C', '\x10E', '\x3', '\x2', '\x2', 
		'\x2', '\x10D', '\x10F', '\a', '~', '\x2', '\x2', '\x10E', '\x10D', '\x3', 
		'\x2', '\x2', '\x2', '\x10E', '\x10F', '\x3', '\x2', '\x2', '\x2', '\x10F', 
		'\x38', '\x3', '\x2', '\x2', '\x2', '\x110', '\x111', '\a', '\x64', '\x2', 
		'\x2', '\x111', ':', '\x3', '\x2', '\x2', '\x2', '\x112', '\x113', '\a', 
		'i', '\x2', '\x2', '\x113', '<', '\x3', '\x2', '\x2', '\x2', '\x114', 
		'\x115', '\a', '\x66', '\x2', '\x2', '\x115', '>', '\x3', '\x2', '\x2', 
		'\x2', '\x116', '\x117', '\a', '|', '\x2', '\x2', '\x117', '@', '\x3', 
		'\x2', '\x2', '\x2', '\x118', '\x11A', '\a', 'm', '\x2', '\x2', '\x119', 
		'\x11B', '\a', 'j', '\x2', '\x2', '\x11A', '\x119', '\x3', '\x2', '\x2', 
		'\x2', '\x11A', '\x11B', '\x3', '\x2', '\x2', '\x2', '\x11B', '\x42', 
		'\x3', '\x2', '\x2', '\x2', '\x11C', '\x11D', '\a', 'n', '\x2', '\x2', 
		'\x11D', '\x44', '\x3', '\x2', '\x2', '\x2', '\x11E', '\x11F', '\a', 'o', 
		'\x2', '\x2', '\x11F', '\x46', '\x3', '\x2', '\x2', '\x2', '\x120', '\x121', 
		'\a', 'p', '\x2', '\x2', '\x121', 'H', '\x3', '\x2', '\x2', '\x2', '\x122', 
		'\x123', '\a', 'z', '\x2', '\x2', '\x123', 'J', '\x3', '\x2', '\x2', '\x2', 
		'\x124', '\x126', '\a', 'r', '\x2', '\x2', '\x125', '\x127', '\t', '\a', 
		'\x2', '\x2', '\x126', '\x125', '\x3', '\x2', '\x2', '\x2', '\x126', '\x127', 
		'\x3', '\x2', '\x2', '\x2', '\x127', 'L', '\x3', '\x2', '\x2', '\x2', 
		'\x128', '\x12A', '\t', '\x2', '\x2', '\x2', '\x129', '\x128', '\x3', 
		'\x2', '\x2', '\x2', '\x129', '\x12A', '\x3', '\x2', '\x2', '\x2', '\x12A', 
		'\x12B', '\x3', '\x2', '\x2', '\x2', '\x12B', '\x12C', '\a', 't', '\x2', 
		'\x2', '\x12C', 'N', '\x3', '\x2', '\x2', '\x2', '\x12D', '\x12E', '\t', 
		'\t', '\x2', '\x2', '\x12E', 'P', '\x3', '\x2', '\x2', '\x2', '\x12F', 
		'\x131', '\a', 'v', '\x2', '\x2', '\x130', '\x132', '\a', 'j', '\x2', 
		'\x2', '\x131', '\x130', '\x3', '\x2', '\x2', '\x2', '\x131', '\x132', 
		'\x3', '\x2', '\x2', '\x2', '\x132', 'R', '\x3', '\x2', '\x2', '\x2', 
		'\x133', '\x134', '\a', '.', '\x2', '\x2', '\x134', 'T', '\x3', '\x2', 
		'\x2', '\x2', '\x135', '\x136', '\a', '=', '\x2', '\x2', '\x136', 'V', 
		'\x3', '\x2', '\x2', '\x2', '\x137', '\x138', '\a', '\x30', '\x2', '\x2', 
		'\x138', 'X', '\x3', '\x2', '\x2', '\x2', '\x139', '\x13A', '\a', '\x41', 
		'\x2', '\x2', '\x13A', 'Z', '\x3', '\x2', '\x2', '\x2', '\x13B', '\x13C', 
		'\a', ')', '\x2', '\x2', '\x13C', '\x13D', '\a', ')', '\x2', '\x2', '\x13D', 
		'\\', '\x3', '\x2', '\x2', '\x2', '\x13E', '\x13F', '\a', '>', '\x2', 
		'\x2', '\x13F', '\x140', '\a', '>', '\x2', '\x2', '\x140', '^', '\x3', 
		'\x2', '\x2', '\x2', '\x141', '\x142', '\a', '@', '\x2', '\x2', '\x142', 
		'\x143', '\a', '@', '\x2', '\x2', '\x143', '`', '\x3', '\x2', '\x2', '\x2', 
		'\x144', '\x145', '\a', '/', '\x2', '\x2', '\x145', '\x146', '\a', '/', 
		'\x2', '\x2', '\x146', '\x62', '\x3', '\x2', '\x2', '\x2', '\x147', '\x149', 
		'\t', '\n', '\x2', '\x2', '\x148', '\x147', '\x3', '\x2', '\x2', '\x2', 
		'\x149', '\x14A', '\x3', '\x2', '\x2', '\x2', '\x14A', '\x148', '\x3', 
		'\x2', '\x2', '\x2', '\x14A', '\x14B', '\x3', '\x2', '\x2', '\x2', '\x14B', 
		'\x64', '\x3', '\x2', '\x2', '\x2', '\x14C', '\x14E', '\a', '\xF', '\x2', 
		'\x2', '\x14D', '\x14C', '\x3', '\x2', '\x2', '\x2', '\x14D', '\x14E', 
		'\x3', '\x2', '\x2', '\x2', '\x14E', '\x14F', '\x3', '\x2', '\x2', '\x2', 
		'\x14F', '\x150', '\a', '\f', '\x2', '\x2', '\x150', '\x66', '\x3', '\x2', 
		'\x2', '\x2', '\x151', '\x152', '\v', '\x2', '\x2', '\x2', '\x152', 'h', 
		'\x3', '\x2', '\x2', '\x2', '/', '\x2', 'j', 'm', 'q', 't', 'w', '|', 
		'\x7F', '\x85', '\x88', '\x8B', '\x90', '\x93', '\x98', '\x9B', '\xA0', 
		'\xA3', '\xA9', '\xB5', '\xC1', '\xC4', '\xCC', '\xCF', '\xD2', '\xD6', 
		'\xD9', '\xDC', '\xE1', '\xE4', '\xEA', '\xED', '\xF0', '\xF5', '\xF8', 
		'\xFD', '\x100', '\x105', '\x108', '\x10E', '\x11A', '\x126', '\x129', 
		'\x131', '\x14A', '\x14D', '\x2',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
} // namespace CshPlgr.Lib.Converter.Generated

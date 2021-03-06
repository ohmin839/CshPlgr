//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.9.3
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from /home/ohmin/workspace/antlr4/antlr4plgr/ConversionGrammar.g4 by ANTLR 4.9.3

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace CshPlgr.Lib.Converter.Generated {
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="ConversionGrammarParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.9.3")]
[System.CLSCompliant(false)]
public interface IConversionGrammarVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="ConversionGrammarParser.letters"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLetters([NotNull] ConversionGrammarParser.LettersContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ConversionGrammarParser.letter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLetter([NotNull] ConversionGrammarParser.LetterContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ConversionGrammarParser.alphabet"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAlphabet([NotNull] ConversionGrammarParser.AlphabetContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>largeNasableGammaGamma</c>
	/// labeled alternative in <see cref="ConversionGrammarParser.largeNasableGamma"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLargeNasableGammaGamma([NotNull] ConversionGrammarParser.LargeNasableGammaGammaContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>largeNasableGammaKappa</c>
	/// labeled alternative in <see cref="ConversionGrammarParser.largeNasableGamma"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLargeNasableGammaKappa([NotNull] ConversionGrammarParser.LargeNasableGammaKappaContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>largeNasableGammaXi</c>
	/// labeled alternative in <see cref="ConversionGrammarParser.largeNasableGamma"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLargeNasableGammaXi([NotNull] ConversionGrammarParser.LargeNasableGammaXiContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>smallNasableGammaGamma</c>
	/// labeled alternative in <see cref="ConversionGrammarParser.smallNasableGamma"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSmallNasableGammaGamma([NotNull] ConversionGrammarParser.SmallNasableGammaGammaContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>smallNasableGammaKappa</c>
	/// labeled alternative in <see cref="ConversionGrammarParser.smallNasableGamma"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSmallNasableGammaKappa([NotNull] ConversionGrammarParser.SmallNasableGammaKappaContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>smallNasableGammaXi</c>
	/// labeled alternative in <see cref="ConversionGrammarParser.smallNasableGamma"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSmallNasableGammaXi([NotNull] ConversionGrammarParser.SmallNasableGammaXiContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ConversionGrammarParser.nonFinalSigma"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNonFinalSigma([NotNull] ConversionGrammarParser.NonFinalSigmaContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>largeAlpha</c>
	/// labeled alternative in <see cref="ConversionGrammarParser.singleAlphabet"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLargeAlpha([NotNull] ConversionGrammarParser.LargeAlphaContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>largeEpsilon</c>
	/// labeled alternative in <see cref="ConversionGrammarParser.singleAlphabet"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLargeEpsilon([NotNull] ConversionGrammarParser.LargeEpsilonContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>largeEta</c>
	/// labeled alternative in <see cref="ConversionGrammarParser.singleAlphabet"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLargeEta([NotNull] ConversionGrammarParser.LargeEtaContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>largeIota</c>
	/// labeled alternative in <see cref="ConversionGrammarParser.singleAlphabet"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLargeIota([NotNull] ConversionGrammarParser.LargeIotaContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>largeOmicron</c>
	/// labeled alternative in <see cref="ConversionGrammarParser.singleAlphabet"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLargeOmicron([NotNull] ConversionGrammarParser.LargeOmicronContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>largeUpsilon</c>
	/// labeled alternative in <see cref="ConversionGrammarParser.singleAlphabet"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLargeUpsilon([NotNull] ConversionGrammarParser.LargeUpsilonContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>largeOmega</c>
	/// labeled alternative in <see cref="ConversionGrammarParser.singleAlphabet"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLargeOmega([NotNull] ConversionGrammarParser.LargeOmegaContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>largeBeta</c>
	/// labeled alternative in <see cref="ConversionGrammarParser.singleAlphabet"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLargeBeta([NotNull] ConversionGrammarParser.LargeBetaContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>largeGamma</c>
	/// labeled alternative in <see cref="ConversionGrammarParser.singleAlphabet"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLargeGamma([NotNull] ConversionGrammarParser.LargeGammaContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>largeDelta</c>
	/// labeled alternative in <see cref="ConversionGrammarParser.singleAlphabet"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLargeDelta([NotNull] ConversionGrammarParser.LargeDeltaContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>largeZeta</c>
	/// labeled alternative in <see cref="ConversionGrammarParser.singleAlphabet"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLargeZeta([NotNull] ConversionGrammarParser.LargeZetaContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>largeKappa</c>
	/// labeled alternative in <see cref="ConversionGrammarParser.singleAlphabet"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLargeKappa([NotNull] ConversionGrammarParser.LargeKappaContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>largeLambda</c>
	/// labeled alternative in <see cref="ConversionGrammarParser.singleAlphabet"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLargeLambda([NotNull] ConversionGrammarParser.LargeLambdaContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>largeMu</c>
	/// labeled alternative in <see cref="ConversionGrammarParser.singleAlphabet"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLargeMu([NotNull] ConversionGrammarParser.LargeMuContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>largeNu</c>
	/// labeled alternative in <see cref="ConversionGrammarParser.singleAlphabet"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLargeNu([NotNull] ConversionGrammarParser.LargeNuContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>largeXi</c>
	/// labeled alternative in <see cref="ConversionGrammarParser.singleAlphabet"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLargeXi([NotNull] ConversionGrammarParser.LargeXiContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>largePi</c>
	/// labeled alternative in <see cref="ConversionGrammarParser.singleAlphabet"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLargePi([NotNull] ConversionGrammarParser.LargePiContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>largeRho</c>
	/// labeled alternative in <see cref="ConversionGrammarParser.singleAlphabet"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLargeRho([NotNull] ConversionGrammarParser.LargeRhoContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>largeSigma</c>
	/// labeled alternative in <see cref="ConversionGrammarParser.singleAlphabet"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLargeSigma([NotNull] ConversionGrammarParser.LargeSigmaContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>largeTau</c>
	/// labeled alternative in <see cref="ConversionGrammarParser.singleAlphabet"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLargeTau([NotNull] ConversionGrammarParser.LargeTauContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>smallAlpha</c>
	/// labeled alternative in <see cref="ConversionGrammarParser.singleAlphabet"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSmallAlpha([NotNull] ConversionGrammarParser.SmallAlphaContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>smallEpsilon</c>
	/// labeled alternative in <see cref="ConversionGrammarParser.singleAlphabet"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSmallEpsilon([NotNull] ConversionGrammarParser.SmallEpsilonContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>smallEta</c>
	/// labeled alternative in <see cref="ConversionGrammarParser.singleAlphabet"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSmallEta([NotNull] ConversionGrammarParser.SmallEtaContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>smallIota</c>
	/// labeled alternative in <see cref="ConversionGrammarParser.singleAlphabet"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSmallIota([NotNull] ConversionGrammarParser.SmallIotaContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>smallOmicron</c>
	/// labeled alternative in <see cref="ConversionGrammarParser.singleAlphabet"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSmallOmicron([NotNull] ConversionGrammarParser.SmallOmicronContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>smallUpsilon</c>
	/// labeled alternative in <see cref="ConversionGrammarParser.singleAlphabet"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSmallUpsilon([NotNull] ConversionGrammarParser.SmallUpsilonContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>smallOmega</c>
	/// labeled alternative in <see cref="ConversionGrammarParser.singleAlphabet"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSmallOmega([NotNull] ConversionGrammarParser.SmallOmegaContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>smallBeta</c>
	/// labeled alternative in <see cref="ConversionGrammarParser.singleAlphabet"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSmallBeta([NotNull] ConversionGrammarParser.SmallBetaContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>smallGamma</c>
	/// labeled alternative in <see cref="ConversionGrammarParser.singleAlphabet"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSmallGamma([NotNull] ConversionGrammarParser.SmallGammaContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>smallDelta</c>
	/// labeled alternative in <see cref="ConversionGrammarParser.singleAlphabet"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSmallDelta([NotNull] ConversionGrammarParser.SmallDeltaContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>smallZeta</c>
	/// labeled alternative in <see cref="ConversionGrammarParser.singleAlphabet"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSmallZeta([NotNull] ConversionGrammarParser.SmallZetaContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>smallKappa</c>
	/// labeled alternative in <see cref="ConversionGrammarParser.singleAlphabet"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSmallKappa([NotNull] ConversionGrammarParser.SmallKappaContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>smallLambda</c>
	/// labeled alternative in <see cref="ConversionGrammarParser.singleAlphabet"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSmallLambda([NotNull] ConversionGrammarParser.SmallLambdaContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>smallMu</c>
	/// labeled alternative in <see cref="ConversionGrammarParser.singleAlphabet"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSmallMu([NotNull] ConversionGrammarParser.SmallMuContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>smallNu</c>
	/// labeled alternative in <see cref="ConversionGrammarParser.singleAlphabet"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSmallNu([NotNull] ConversionGrammarParser.SmallNuContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>smallXi</c>
	/// labeled alternative in <see cref="ConversionGrammarParser.singleAlphabet"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSmallXi([NotNull] ConversionGrammarParser.SmallXiContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>smallPi</c>
	/// labeled alternative in <see cref="ConversionGrammarParser.singleAlphabet"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSmallPi([NotNull] ConversionGrammarParser.SmallPiContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>smallRho</c>
	/// labeled alternative in <see cref="ConversionGrammarParser.singleAlphabet"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSmallRho([NotNull] ConversionGrammarParser.SmallRhoContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>smallSigma</c>
	/// labeled alternative in <see cref="ConversionGrammarParser.singleAlphabet"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSmallSigma([NotNull] ConversionGrammarParser.SmallSigmaContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>smallTau</c>
	/// labeled alternative in <see cref="ConversionGrammarParser.singleAlphabet"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSmallTau([NotNull] ConversionGrammarParser.SmallTauContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>comma</c>
	/// labeled alternative in <see cref="ConversionGrammarParser.punctuation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitComma([NotNull] ConversionGrammarParser.CommaContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>semicoron</c>
	/// labeled alternative in <see cref="ConversionGrammarParser.punctuation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSemicoron([NotNull] ConversionGrammarParser.SemicoronContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>period</c>
	/// labeled alternative in <see cref="ConversionGrammarParser.punctuation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPeriod([NotNull] ConversionGrammarParser.PeriodContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>question</c>
	/// labeled alternative in <see cref="ConversionGrammarParser.punctuation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitQuestion([NotNull] ConversionGrammarParser.QuestionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>apostroph</c>
	/// labeled alternative in <see cref="ConversionGrammarParser.punctuation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitApostroph([NotNull] ConversionGrammarParser.ApostrophContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>lguillemet</c>
	/// labeled alternative in <see cref="ConversionGrammarParser.punctuation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLguillemet([NotNull] ConversionGrammarParser.LguillemetContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>rguillemet</c>
	/// labeled alternative in <see cref="ConversionGrammarParser.punctuation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRguillemet([NotNull] ConversionGrammarParser.RguillemetContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>emdash</c>
	/// labeled alternative in <see cref="ConversionGrammarParser.punctuation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEmdash([NotNull] ConversionGrammarParser.EmdashContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>space</c>
	/// labeled alternative in <see cref="ConversionGrammarParser.whitespace"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSpace([NotNull] ConversionGrammarParser.SpaceContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>newline</c>
	/// labeled alternative in <see cref="ConversionGrammarParser.whitespace"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNewline([NotNull] ConversionGrammarParser.NewlineContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>anychar</c>
	/// labeled alternative in <see cref="ConversionGrammarParser.otherwise"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAnychar([NotNull] ConversionGrammarParser.AnycharContext context);
}
} // namespace CshPlgr.Lib.Converter.Generated

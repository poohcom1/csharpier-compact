using CSharpier.DocTypes;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpier.SyntaxPrinter.SyntaxNodePrinters
{
    public static class LetClause
    {
        public static Doc Print(LetClauseSyntax node)
        {
            return Doc.Concat(
                Token.PrintWithSuffix(node.LetKeyword, " "),
                Token.PrintWithSuffix(node.Identifier, " "),
                Token.PrintWithSuffix(node.EqualsToken, " "),
                Node.Print(node.Expression)
            );
        }
    }
}

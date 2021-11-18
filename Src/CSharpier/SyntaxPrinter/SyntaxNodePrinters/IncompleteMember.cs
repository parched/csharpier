using CSharpier.DocTypes;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpier.SyntaxPrinter.SyntaxNodePrinters;

internal static class IncompleteMember
{
    public static Doc Print(IncompleteMemberSyntax node)
    {
        return string.Empty;
    }
}

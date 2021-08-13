using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Diagnostics;

using System;

namespace CA2002
{
    [DiagnosticAnalyzer(LanguageNames.CSharp)]
    public class DoNotLockOnObjectsWithWeakIdentityAnalyzerCSharp : DoNotLockOnObjectsWithWeakIdentityAnalyzerBase
    {
        protected override bool IsThisExpression(SyntaxNode node) => node is ThisExpressionSyntax;
    }
}

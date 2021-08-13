Imports CA2002

Imports Microsoft.CodeAnalysis
Imports Microsoft.CodeAnalysis.Diagnostics
Imports Microsoft.CodeAnalysis.VisualBasic.Syntax

<DiagnosticAnalyzer(LanguageNames.VisualBasic)>
Public Class DoNotLockOnObjectsWithWeakIdentityAnalyzerVisualBasic
    Inherits DoNotLockOnObjectsWithWeakIdentityAnalyzerBase

    Protected Overrides Function IsThisExpression(node As SyntaxNode) As Boolean
        Return TryCast(node, MeExpressionSyntax) IsNot Nothing
    End Function
End Class

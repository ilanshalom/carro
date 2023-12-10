Public Class Aluno
    Inherits Pessoa

    Private prgm As String

    Sub New(ByVal innome As String, ByVal incpf As String, ByVal inrgm As String)
        MyBase.New(innome, incpf)
        Me.Rgm = inrgm
    End Sub

    Property Rgm As String
        Get
            Return prgm
        End Get
        Set(ByVal valor As String)
            Me.prgm = valor
        End Set
    End Property

    Public Overrides Function toString() As String
        Return Rgm + " - " + Nome + " - " + Cpf
    End Function

End Class


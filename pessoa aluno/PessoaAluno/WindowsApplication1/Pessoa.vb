Public Class Pessoa
    Private pcpf As String
    Private pnome As String

    Public Sub New(innome As String, incpf As String)
        Cpf = incpf
        Nome = innome
    End Sub
    Public Property Nome As String
        Get
            Return Me.pnome
        End Get
        Set(ByVal valor As String)
            Me.pnome = valor
        End Set
    End Property

    Public Property Cpf As String
        Get
            Return pcpf
        End Get
        Set(ByVal valor As String)
            pcpf = valor
        End Set
    End Property

End Class

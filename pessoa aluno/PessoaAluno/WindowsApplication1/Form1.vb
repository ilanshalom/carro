Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim aluno1 As New Aluno("José Alves", "123.456.789-10", "1234-5")
        MsgBox("Dados: " & aluno1.Rgm & " - " & aluno1.Nome & " - " & aluno1.Cpf, MsgBoxStyle.Information, "Aluno criado")
        'ou assim:  MsgBox("Dados: " & aluno1.toString(), MsgBoxStyle.Information, "Aluno criado")

        'Mostrar também o aluno com os dados digitados pelo usuário:
        Dim cpf = TextBox1.Text
        Dim nome = TextBox2.Text
        Dim rgm = TextBox3.Text
        'criar um objeto da classe Aluno com os dados anteriores
        Dim aluno2 As New Aluno(nome, cpf, rgm)
        MsgBox(aluno2.toString(), MsgBoxStyle.Information, "Aluno criado")
    End Sub
End Class

Imports Clases

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim pal As String = "hola"
        Dim var As New Validaciones
        MessageBox.Show(Validaciones.EsPalindroma("k"))
        If Validaciones.DatoValido("ABC", pal) Then

        End If
    End Sub
End Class

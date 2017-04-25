Public Class Validaciones

    Public Shared Function DatoValido(ByVal caracteresValidos As String, ByVal cadenaValidar As String) As Boolean
        For Each car As Char In cadenaValidar
            If Not caracteresValidos.Contains(car) Then Return False
        Next
        Return True
    End Function
    Public Overloads Shared Function EsPalindroma(ByVal pal As String) As Boolean
        'Dim pal2 As System.Collections.Generic.IEnumerable(Of Char) = pal.ToCharArray
        pal = SinCaracteresRaros(pal)
        Return pal.ToUpper = StrReverse(pal.ToUpper)
        'Return pal2 Is pal.Reverse
    End Function
    Public Overloads Shared Function EsPalindroma(ByVal numero As Long) As Boolean
        Dim pal As String = numero.ToString
        Return EsPalindroma(pal)
    End Function
    Public Overloads Shared Function EsPalindroma(ByVal fecha As Date) As Boolean
        Dim pal As String = fecha.Date
        Return EsPalindroma(pal)
    End Function
    Private Shared Function SinCaracteresRaros(ByVal pal As String) As String
        Const No = "/ -.,"
        For i = pal.Length - 1 To 0 Step -1
            If No.Contains(pal.Chars(i)) Then
                pal = pal.Remove(i, 1)
            End If
        Next
        Const tildes = "ÁÉÍÓÚáéíóú"
        Const vocales = "AEIOUaeiou"
        Dim pal2 As String = ""
        For i = 0 To pal.Length - 1
            Dim pos As Integer = tildes.IndexOf(pal.Chars(i))
            If pos = -1 Then
                pal2 &= pal.Chars(i)
            Else
                pal2 &= vocales.Substring(pos, 1)
            End If
        Next
        Return pal2
    End Function
End Class

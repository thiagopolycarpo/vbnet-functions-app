Public Module ContadorVogais
    Public Function ContarVogais(input As String) As Integer
        If input Is Nothing Then
            Return 0
        End If
        Dim count As Integer = 0
        For Each c As Char In input
            If "aeiouáéíóúâêôãõAEIOUÁÉÍÓÚÂÊÔÃÕ".IndexOf(c) >= 0 Then
                count += 1
            End If
        Next
        Return count
    End Function
End Module
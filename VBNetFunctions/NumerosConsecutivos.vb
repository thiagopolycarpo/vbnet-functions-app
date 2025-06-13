Public Module NumerosConsecutivos
    Public Function TemTresConsecutivosCrescentes(numbers As Integer()) As Boolean
        If numbers Is Nothing OrElse numbers.Length < 3 Then
            Return False
        End If
        For i As Integer = 0 To numbers.Length - 3
            If numbers(i) + 1 = numbers(i + 1) AndAlso numbers(i + 1) + 1 = numbers(i + 2) Then
                Return True
            End If
        Next
        Return False
    End Function
End Module
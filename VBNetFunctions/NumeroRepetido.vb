Public Module NumeroRepetido
    Public Function EncontrarPrimeiroRepetido(numbers As Integer()) As Integer
        If numbers Is Nothing OrElse numbers.Length = 0 Then
            Return -1
        End If
        Dim vistos As New HashSet(Of Integer)()
        For Each num As Integer In numbers
            If vistos.Contains(num) Then
                Return num
            End If
            vistos.Add(num)
        Next
        Return -1
    End Function
End Module
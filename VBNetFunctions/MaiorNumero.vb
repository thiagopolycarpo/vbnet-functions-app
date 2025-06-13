Public Module MaiorNumero
    ' Finds the largest number in an integer array
    Public Function EncontrarMaiorNumero(numbers As Integer()) As Integer
        If numbers Is Nothing OrElse numbers.Length = 0 Then
            Throw New ArgumentException("O array não pode ser nulo ou vazio.")
        End If
        Dim max As Integer = numbers(0)
        For Each number As Integer In numbers
            If number > max Then
                max = number
            End If
        Next
        Return max
    End Function
End Module
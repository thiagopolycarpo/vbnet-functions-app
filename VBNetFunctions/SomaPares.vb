Public Module SomaPares
    ' Sums all even numbers in an array; returns 0 if null or empty
    Public Function SomarNumerosPares(numbers As Integer()) As Integer
        If numbers Is Nothing OrElse numbers.Length = 0 Then
            Return 0
        End If
        Dim sum As Integer = 0
        For Each number As Integer In numbers
            If number Mod 2 = 0 Then
                sum += number
            End If
        Next
        Return sum
    End Function
End Module
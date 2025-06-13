Public Module NumerosNaoRepetidos
    Public Function ObterNumerosUnicos(numbers As Integer()) As Integer()
        If numbers Is Nothing OrElse numbers.Length = 0 Then
            Return New Integer() {}
        End If
        Dim frequencia As New Dictionary(Of Integer, Integer)()
        For Each num As Integer In numbers
            If frequencia.ContainsKey(num) Then
                frequencia(num) += 1
            Else
                frequencia.Add(num, 1)
            End If
        Next
        Dim unicos As New List(Of Integer)()
        For Each num As Integer In numbers
            If frequencia(num) = 1 Then
                unicos.Add(num)
            End If
        Next
        Return unicos.ToArray()
    End Function
End Module
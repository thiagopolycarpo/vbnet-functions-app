Public Module MediaPonderada
    Public Function CalcularMediaPonderada(notas As Decimal(), pesos As Integer()) As Decimal
        If notas Is Nothing OrElse pesos Is Nothing Then
            Throw New ArgumentException("As listas de notas e pesos não podem ser nulas.")
        End If
        If notas.Length <> pesos.Length Then
            Throw New ArgumentException("As listas de notas e pesos devem ter o mesmo tamanho.")
        End If
        Dim resultado As Decimal = 0
        Dim divisao As Decimal = 0
        For i As Integer = 0 To notas.Length - 1
            resultado += notas(i) * pesos(i)
            divisao += pesos(i)
        Next
        If divisao = 0 Then
            Throw New ArgumentException("A soma dos pesos não pode ser zero.")
        End If
        Return resultado / divisao
    End Function
End Module
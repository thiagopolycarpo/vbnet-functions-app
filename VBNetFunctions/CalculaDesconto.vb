Namespace CalculaDesconto
    Public Module CalculaDesconto
        Public Function CalcularDesconto(price As Decimal) As Decimal
            If price < 0 Then
                Throw New ArgumentException("O preço não pode ser negativo.")
            End If
            If price > 200 Then
                Return price * 0.8D
            ElseIf price > 100 Then
                Return price * 0.9D
            End If
            Return price
        End Function
    End Module
End Namespace
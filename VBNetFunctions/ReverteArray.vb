Public Module ReverteArray
    Public Function ReverterArray(array As Integer()) As Integer()
        If array Is Nothing Then
            Throw New ArgumentException("O array não pode ser nulo.")
        End If
        If array.Length <= 1 Then
            Return array
        End If
        Dim reversed(array.Length - 1) As Integer
        For i As Integer = 0 To array.Length - 1
            reversed(i) = array(array.Length - 1 - i)
        Next
        Return reversed
    End Function
End Module
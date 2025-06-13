Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports VBNetFunctions

<TestClass>Public Class MaiorNumeroTests
   <TestMethod>
    Public Sub EncontrarMaiorNumero_ValidInput_ReturnsMax()
        Dim numbers As Integer() = New Integer() {1, 5, 3, 8, 2, 7}
        Assert.AreEqual(8, MaiorNumero.EncontrarMaiorNumero(numbers))
    End Sub

    <TestMethod>
    Public Sub EncontrarMaiorNumero_EmptyArray_ThrowsException()
        Assert.Throws(Of ArgumentException)(Sub() MaiorNumero.EncontrarMaiorNumero(New Integer() {}))
    End Sub
End Class
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports VBNetFunctions

<TestClass>
Public Class NumerosConsecutivosTests
   <TestMethod>
    Public Sub TemTresConsecutivosCrescentes_ValidInput_ReturnsCorrectResult()
        Dim lista1 As Integer() = New Integer() {5, 6, 7, 2, 1}
        Dim lista2 As Integer() = New Integer() {1, 3, 4, 6}
        Dim lista3 As Integer() = New Integer() {1, 2, 3}
        Assert.IsTrue(NumerosConsecutivos.TemTresConsecutivosCrescentes(lista1))
        Assert.IsFalse(NumerosConsecutivos.TemTresConsecutivosCrescentes(lista2))
        Assert.IsTrue(NumerosConsecutivos.TemTresConsecutivosCrescentes(lista3))
        Assert.IsFalse(NumerosConsecutivos.TemTresConsecutivosCrescentes(New Integer() {}))
        Assert.IsFalse(NumerosConsecutivos.TemTresConsecutivosCrescentes(Nothing))
    End Sub
End Class
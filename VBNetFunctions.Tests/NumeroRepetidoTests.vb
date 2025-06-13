Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports VBNetFunctions

<TestClass>
Public Class NumeroRepetidoTests
  <TestMethod>
    Public Sub EncontrarPrimeiroRepetido_ValidInput_ReturnsFirstRepeated()
        Dim lista1 As Integer() = New Integer() {1, 2, 3, 4, 2, 5}
        Dim lista2 As Integer() = New Integer() {1, 3, 4, 6, 3, 2}
        Dim lista3 As Integer() = New Integer() {1, 2, 3}
        Assert.AreEqual(2, NumeroRepetido.EncontrarPrimeiroRepetido(lista1))
        Assert.AreEqual(3, NumeroRepetido.EncontrarPrimeiroRepetido(lista2))
        Assert.AreEqual(-1, NumeroRepetido.EncontrarPrimeiroRepetido(lista3))
        Assert.AreEqual(-1, NumeroRepetido.EncontrarPrimeiroRepetido(New Integer() {}))
        Assert.AreEqual(-1, NumeroRepetido.EncontrarPrimeiroRepetido(Nothing))
    End Sub
End Class
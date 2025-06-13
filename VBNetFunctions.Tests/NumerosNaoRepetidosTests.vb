Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports VBNetFunctions

<TestClass>
Public Class NumerosNaoRepetidosTests
    <TestMethod>
    Public Sub ObterNumerosUnicos_ValidInput_ReturnsUniqueNumbers()
        Dim lista1 As Integer() = New Integer() {1, 2, 2, 3, 4, 4, 5}
        Dim lista2 As Integer() = New Integer() {1, 1, 1, 2, 2}
        Dim lista3 As Integer() = New Integer() {1, 2, 3}
        Dim expected1 As Integer() = New Integer() {1, 3, 5}
        Dim expected2 As Integer() = New Integer() {}
        Dim expected3 As Integer() = New Integer() {1, 2, 3}
         CollectionAssert.AreEqual(expected1, NumerosNaoRepetidos.ObterNumerosUnicos(lista1))
         CollectionAssert.AreEqual(expected2, NumerosNaoRepetidos.ObterNumerosUnicos(lista2))
         CollectionAssert.AreEqual(expected3, NumerosNaoRepetidos.ObterNumerosUnicos(lista3))
         CollectionAssert.AreEqual(New Integer() {}, NumerosNaoRepetidos.ObterNumerosUnicos(New Integer() {}))
         CollectionAssert.AreEqual(New Integer() {}, NumerosNaoRepetidos.ObterNumerosUnicos(Nothing))
    End Sub
End Class
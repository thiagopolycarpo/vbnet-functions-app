Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports VBNetFunctions

<TestClass>
Public Class SomaParesTests
    <TestMethod>
    Public Sub SomarNumerosPares_ValidInput_ReturnsSum()
        Dim numbers As Integer() = New Integer() {1, 2, 3, 4, 5, 6, 8}
        Assert.AreEqual(20, SomaPares.SomarNumerosPares(numbers))
    End Sub

    <TestMethod>
    Public Sub SomarNumerosPares_EmptyArray_ReturnsZero()
        Assert.AreEqual(0, SomaPares.SomarNumerosPares(New Integer() {}))
    End Sub

    <TestMethod>
    Public Sub SomarNumerosPares_NullArray_ReturnsZero()
        Assert.AreEqual(0, SomaPares.SomarNumerosPares(Nothing))
    End Sub

End Class
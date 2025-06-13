Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports VBNetFunctions

<TestClass>
Public Class MediaPonderadaTests
    <TestMethod>
    Public Sub CalcularMediaPonderada_ValidInput_ReturnsWeightedAverage()
        Dim notas As Decimal() = New Decimal() {7.5D, 8.0D, 9.0D}
        Dim pesos As Integer() = New Integer() {2, 3, 5}
        Assert.AreEqual(8.4D, MediaPonderada.CalcularMediaPonderada(notas, pesos), 0.01D)
    End Sub

    <TestMethod>
    Public Sub CalcularMediaPonderada_NullInput_ThrowsException()
        Assert.Throws(Of ArgumentException)(Sub() MediaPonderada.CalcularMediaPonderada(Nothing, New Integer() {1}))
        Assert.Throws(Of ArgumentException)(Sub() MediaPonderada.CalcularMediaPonderada(New Decimal() {1D}, Nothing))
    End Sub
End Class
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports VBNetFunctions

<TestClass>
Public Class CalculaDescontoTests
    <TestMethod>
    Public Sub CalcularDesconto_ValidInput_ReturnsDiscountedPrice()
        Assert.AreEqual(50D, CalculaDesconto.CalculaDesconto.CalcularDesconto(50D))
        Assert.AreEqual(135D, CalculaDesconto.CalculaDesconto.CalcularDesconto(150D))
        Assert.AreEqual(200D, CalculaDesconto.CalculaDesconto.CalcularDesconto(250D))
    End Sub

    <TestMethod>
    Public Sub CalcularDesconto_ZeroPrice_ReturnsZero()
        Assert.AreEqual(0D, CalculaDesconto.CalculaDesconto.CalcularDesconto(0D))
    End Sub

    <TestMethod>
    Public Sub CalcularDesconto_NegativePrice_ThrowsException()
        Assert.Throws(Of ArgumentException)(Sub() CalculaDesconto.CalculaDesconto.CalcularDesconto(-50D))
    End Sub
End Class
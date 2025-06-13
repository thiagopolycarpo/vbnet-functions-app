Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports VBNetFunctions

<TestClass>
Public Class ContadorVogaisTests
    <TestMethod>
    Public Sub ContarVogais_ValidInput_ReturnsCount()
        Assert.AreEqual(4, ContadorVogais.ContarVogais("Olá, Mundo!"))
        Assert.AreEqual(5, ContadorVogais.ContarVogais("aeiou"))
        Assert.AreEqual(5, ContadorVogais.ContarVogais("AEIOU"))
        Assert.AreEqual(0, ContadorVogais.ContarVogais("xyz"))
        Assert.AreEqual(0, ContadorVogais.ContarVogais(""))
        Assert.AreEqual(0, ContadorVogais.ContarVogais(Nothing))
    End Sub
End Class
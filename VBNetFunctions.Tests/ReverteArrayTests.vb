Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports VBNetFunctions

<TestClass>
Public Class ReverteArrayTests

    <TestMethod>
    Public Sub ReverterArray_ValidInput_ReturnsReversedArray()
        Dim input As Integer() = New Integer() {1, 2, 3, 4, 5}
        Dim expected As Integer() = New Integer() {5, 4, 3, 2, 1}
        CollectionAssert.AreEqual(expected, ReverteArray.ReverterArray(input))
    End Sub

    <TestMethod>
    Public Sub ReverterArray_EmptyArray_ReturnsEmpty()
        Dim input As Integer() = New Integer() {}
        CollectionAssert.AreEqual(input, ReverteArray.ReverterArray(input))
    End Sub

    <TestMethod>
    Public Sub ReverterArray_NullArray_ThrowsException()
        Assert.Throws(Of ArgumentException)(Sub() ReverteArray.ReverterArray(Nothing))
    End Sub
End Class

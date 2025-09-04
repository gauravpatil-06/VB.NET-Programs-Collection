Module Program
    Sub Main()
        Dim NumArray() As Integer = {10, 20, 30, 40, 50}
        Dim i As Integer
        For Each i In NumArray
            Console.WriteLine("i={0}", i)
        Next
    End Sub
End Module

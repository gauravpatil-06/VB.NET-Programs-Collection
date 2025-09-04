Imports System

Module Program
    Sub Main(args As String())
        Dim i As Integer
        Dim no As Integer
        Dim fact As Integer = 1
        Console.WriteLine("Enter Integer Number:")
        no = Console.ReadLine()
        For i = 1 To no
            fact = fact * i
        Next
        Console.WriteLine("Factorial Number:{0}", fact)
    End Sub
End Module

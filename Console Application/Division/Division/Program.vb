Imports System
Module Program
    Sub Main(args As String())
        Dim a As Integer
        Dim b As Integer
        Dim c As Integer
        Console.WriteLine("Enter your first number:")
        a = Console.ReadLine()
        Console.WriteLine("Enter your second number:")
        b = Console.ReadLine()
        c = a / b
        Console.WriteLine("Division of Two numbers={0}", c)
    End Sub
End Module

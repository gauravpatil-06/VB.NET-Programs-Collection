Imports System
Module Program
    Sub division()
        Dim a As Integer = 10
        Dim b As Integer = 0
        Dim c As Integer
        Try
            c = a / b
            Console.WriteLine("Division={0}", c)
        Catch ex As Exception
            Console.WriteLine("Divide by zero Ecception is occurred!!!")
        Finally
            Console.WriteLine("A am always executed!!!")
        End Try
    End Sub
    Sub Main(args As String())
        division()
    End Sub
End Module

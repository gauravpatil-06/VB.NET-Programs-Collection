Imports System

Module Program
    Public Class addition
        Dim a, b As Integer
        Overloads Sub addition(x As Integer)
            a = x
            b = 100
            Console.WriteLine("Addition={0}", (a + b))
        End Sub
        Overloads Sub addition(x As Integer, y As Integer)
            a = x
            b = y
            Console.WriteLine("Addition={0}", (a + b))
        End Sub
    End Class

    Sub Main(args As String())
        Dim a1 As New addition()
        Dim a2 As New addition()
        a1.addition(50)
        a1.addition(100, 200)
    End Sub
End Module

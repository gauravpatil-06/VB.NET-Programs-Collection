Imports System
Module Program
    Sub division()
        Dim a As Integer = 20
        Dim b As Integer = 10
        Dim c As Integer
        Try
            c = a \ b
            Console.WriteLine("Division={0}", c)
            Throw New DivideByZeroException("Gaurav Patil")
        Catch ex As DivideByZeroException
            Console.WriteLine("Divide by zero Ecception is occurred={0}", ex)
        Catch ex As NullReferenceException
            Console.WriteLine("Null Reference Exceptionis occurred!!!")
        Finally
            Console.WriteLine("A am always executed!!!")
        End Try
    End Sub
    Sub Main(args As String())
        division()
    End Sub
End Module

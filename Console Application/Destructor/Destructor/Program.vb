Imports System
Module Program
    Public Class sample
        Sub New()
            Console.WriteLine("Constructor called successfully!!!")
        End Sub
        Protected Overrides Sub finalize()
            Console.WriteLine("Destructor called successfully!!!")
            MyBase.Finalize()
        End Sub
    End Class
    Sub Main(args As String())
        Dim s1 As New sample()
    End Sub
End Module

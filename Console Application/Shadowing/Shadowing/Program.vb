Imports System

Module Program
    Class base
        Sub show()
            Console.WriteLine("Show method of base class")
        End Sub
    End Class
    Class derived
        Inherits base
        Shadows Sub show()
            MyBase.show()
            Console.WriteLine("Show method of derived class")
        End Sub
    End Class

    Sub Main(args As String())
        Dim d1 As New derived()
        d1.show()
    End Sub
End Module

Imports System

Module Program
    Public Class vehicle
        Dim vehicle_name As String
        Sub New(vn As String)
            vehicle_name = vn
            Console.WriteLine("Constructor called successfully!!!")
        End Sub
        Sub display()
            Console.WriteLine("Vehicle Number:{0}", vehicle_name)
        End Sub
    End Class
    Sub Main(args As String())
        Dim v1 As New vehicle("MH23G567")
        v1.display()
    End Sub
End Module

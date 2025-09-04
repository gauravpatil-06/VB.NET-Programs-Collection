Imports System
Imports System.Windows

Module Program
    Public Class student
        Dim rollno As Integer
        Dim name As String
        Dim age As Decimal
        Function get_stud_info()
            Console.WriteLine("Enter Student Roll No:")
            rollno = Console.ReadLine()
            Console.WriteLine("Enter Student Name:")
            name = Console.ReadLine()
            Console.WriteLine("Enter Student Age:")
            age = Console.ReadLine()
        End Function
        Function display_stud_info()
            Console.WriteLine("*******Student Information******")
            Console.WriteLine("Roll No      :{0}", rollno)
            Console.WriteLine("Name         :{0}", name)
            Console.WriteLine("Age          :{0}", age)
        End Function
    End Class
    Public Class Test
        Inherits student
        Dim marks1 As Integer
        Dim marks2 As Integer
        Function get_Test_info()
            Console.WriteLine("Enter Student mark Test-1:")
            marks1 = Console.ReadLine()
            Console.WriteLine("Enter Student mark Test-2:")
            marks2 = Console.ReadLine()
        End Function
        Function display_Test_info()
            Console.WriteLine("Test-1 marks :{0}", marks1)
            Console.WriteLine("Test-2 Marks :{0}", marks2)
        End Function
    End Class
    Sub Main(args As String())
        Dim s1 As New Test()
        s1.get_stud_info()
        s1.get_Test_info()
        s1.display_stud_info()
        s1.display_Test_info()
    End Sub
End Module

Imports System

Module Program
    Public Class student
        Dim rollno As Integer
        Dim name As String
        Dim marks As Decimal
        Function getdata()
            Console.WriteLine("Enter Student Roll No:")
            rollno = Console.ReadLine()
            Console.WriteLine("Enter Student Name:")
            name = Console.ReadLine()
            Console.WriteLine("Enter Student Marks:")
            marks = Console.ReadLine()
        End Function
        Function display()
            Console.WriteLine("*******Student Information******")
            Console.WriteLine("Roll No:{0}", rollno)
            Console.WriteLine("Name   :{0}", name)
            Console.WriteLine("Marks  :{0}", marks)
            Console.WriteLine("********************************")
        End Function
    End Class
    Sub Main(args As String())
        Dim s1 As New student()
        s1.getdata()
        s1.display()
    End Sub
End Module

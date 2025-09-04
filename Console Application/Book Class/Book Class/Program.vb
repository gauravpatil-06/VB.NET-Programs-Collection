Imports System
Imports System.Text.Encodings.Web

Module Program
    Public Class Book
        Dim book_id As Integer
        Dim book_name As String
        Dim book_price As Decimal
        Function getdata(id As Integer, name As String, price As Decimal)
            book_id = id
            book_name = name
            book_price = price
        End Function
        Function display()
            Console.WriteLine("*******Book Information******")
            Console.WriteLine("Book ID    :{0}", book_id)
            Console.WriteLine("Book Name  :{0}", book_name)
            Console.WriteLine("Book Price :{0}", book_price)
            Console.WriteLine("*****************************")
        End Function
    End Class
    Sub Main(args As String())
        Dim b1 As New Book()
        b1.getdata(101, "Java", 199.5)
        b1.display()
    End Sub
End Module

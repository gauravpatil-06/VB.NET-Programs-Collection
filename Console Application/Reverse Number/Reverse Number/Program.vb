Imports System
Module Program
    Sub Main(args As String())
        Dim no As Integer
        Dim remainder As Integer
        Dim rev As Integer = 0
        Console.WriteLine("Enter Any Number:")
        no = Console.ReadLine()
        While no > 0
            remainder = no Mod 10
            rev = rev * 10 + remainder
            no = no / 10
        End While
        Console.WriteLine("Reverse Number:{0}", rev)
    End Sub
End Module
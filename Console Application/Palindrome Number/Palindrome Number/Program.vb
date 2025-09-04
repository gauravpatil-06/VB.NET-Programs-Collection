Imports System
Module Program
    Sub Main(args As String())
        Dim no As Integer
        Dim N As Integer
        Dim remainder As Integer
        Dim rev As Integer = 0
        Console.WriteLine("Enter Any Number:")
        no = Console.ReadLine()
        N = no
        While no > 0
            remainder = no Mod 10
            rev = rev * 10 + remainder
            no = no / 10
        End While
        If N = rev Then
            Console.WriteLine("Palindrome Number")
        Else
            Console.WriteLine("Not Palindrome Number")
        End If
    End Sub
End Module

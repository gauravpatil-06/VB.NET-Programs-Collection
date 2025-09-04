Imports System
Module Program
    Sub Main(args As String())
        Dim no As Integer
        Dim N As Integer
        Dim remainder As Integer
        Dim res As Integer = 0
        Console.WriteLine("Enter Any Number:")
        no = Console.ReadLine()
        N = no
        While no <> 0
            remainder = no Mod 10
            res = res + (remainder * remainder * remainder)
            no = no / 10
        End While
        If N = res Then
            Console.WriteLine("Armstrong Number")
        Else
            Console.WriteLine("Not Armstrong Number")
        End If
    End Sub
End Module

Imports System
Module Program
    Sub Main(args As String())
        Dim a As Integer = False
        Dim b As Integer = True
        Dim c As Integer
        c = 7 And 6
        Console.WriteLine("Bitwise AND Operators ={0}", c)
        c = 7 Or 6
        Console.WriteLine("Bitwise OR Operators  ={0}", c)
        c = 11 Xor 5
        Console.WriteLine("Bitwise XOR Operators ={0}", c)
        If (a And b) Then
            Console.WriteLine("Both Logical AND Conditions are True")
        End If
        If (a Or b) Then
            Console.WriteLine("Both Logical OR Conditions are True")
        End If
        If (Not a) Then
            Console.WriteLine("Both Logical NOT Conditions are True")
        End If
    End Sub
End Module
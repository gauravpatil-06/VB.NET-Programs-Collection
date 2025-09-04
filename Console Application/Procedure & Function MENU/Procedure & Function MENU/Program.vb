Imports System
Module program
    Sub Main()
        Dim ch As Integer
        Dim a As Integer
        Dim b As Integer
        Dim c As Integer
        Console.WriteLine("==========================")
        Console.WriteLine("===========MENU===========")
        Console.WriteLine("==========================")
        Console.WriteLine("1. Addition:")
        Console.WriteLine("2. Substraction:")
        Console.WriteLine("3. Multiplication:")
        Console.WriteLine("4. Division:")
        Console.WriteLine("==========================")
        Console.WriteLine("Enter Your Choice:")
        ch = Integer.Parse(Console.ReadLine())
        Select Case ch
            Case 1
                Addition()
            Case 2
                Substraction()
            Case 3
                Multiplication(a, b)
            Case 4
                Division(a, b)
            Case Else
                Console.WriteLine("Invalid choice")
        End Select
    End Sub
    Sub Addition()
        Dim a, b, c As Integer
        Console.WriteLine("Enter First Number:")
        a = Console.ReadLine()
        Console.WriteLine("Enter Second Number:")
        b = Console.ReadLine()
        c = a + b
        Console.WriteLine("Addition={0}", c)
    End Sub
    Sub Substraction()
        Dim a, b, c As Integer
        Console.WriteLine("Enter First Number:")
        a = Console.ReadLine()
        Console.WriteLine("Enter Second Number:")
        b = Console.ReadLine()
        c = a - b
        Console.WriteLine("Substraction={0}", c)
    End Sub
    Sub Multiplication(a As Integer, b As Integer)
        Console.WriteLine("Enter First Number:")
        a = Console.ReadLine()
        Console.WriteLine("Enter Second Number:")
        b = Console.ReadLine()
        Dim c = a * b
        Console.WriteLine("Multiplication={0}", c)
    End Sub
    Sub Division(a As Integer, b As Integer)
        Console.WriteLine("Enter First Number:")
        a = Console.ReadLine()
        Console.WriteLine("Enter Second Number:")
        b = Console.ReadLine()
        Dim c = a / b
        Console.WriteLine("Division={0}", c)
    End Sub
End Module

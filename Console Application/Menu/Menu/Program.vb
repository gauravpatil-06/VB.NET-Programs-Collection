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
                Console.WriteLine("Enter First Number:")
                a = Console.ReadLine()
                Console.WriteLine("Enter Second Number:")
                b = Console.ReadLine()
                c = a + b
                Console.WriteLine("Addition={0}", c)

            Case 2
                Console.WriteLine("Enter First Number:")
                a = Console.ReadLine()
                Console.WriteLine("Enter Second Number:")
                b = Console.ReadLine()
                c = a - b
                Console.WriteLine("Substraction={0}", c)
            Case 3
                Console.WriteLine("Enter First Number:")
                a = Console.ReadLine()
                Console.WriteLine("Enter Second Number:")
                b = Console.ReadLine()
                c = a * b
                Console.WriteLine("Multiplication={0}", c)
            Case 4
                Console.WriteLine("Enter First Number:")
                a = Console.ReadLine()
                Console.WriteLine("Enter Second Number:")
                b = Console.ReadLine()
                c = a / b
                Console.WriteLine("Division={0}", c)
            Case Else
                Console.WriteLine("Invalid choice")
        End Select
    End Sub
End Module

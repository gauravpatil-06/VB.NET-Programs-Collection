Module program
    Sub Main()
        Dim ch As Integer
        Console.WriteLine("==========================")
        Console.WriteLine("Select your Best Language:")
        Console.WriteLine("==========================")
        Console.WriteLine("1. C Language")
        Console.WriteLine("2. C++ Language")
        Console.WriteLine("3. Java Language")
        Console.WriteLine("==========================")
        Console.WriteLine("Enter Your Choice:")
        ch = Integer.Parse(Console.ReadLine())
        Select Case ch
            Case 1
                Console.WriteLine("Your favourite language is C ")
            Case 2
                Console.WriteLine("Your favourite language is C++ ")
            Case 3
                Console.WriteLine("Your favourite language is Java ")
            Case Else
                Console.WriteLine("Invalid choice")
        End Select
    End Sub
End Module
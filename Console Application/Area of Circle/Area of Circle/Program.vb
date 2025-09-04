'Write a VB.NET Program to calculate area of circle.
Imports System
Module Program
    Sub Main(args As String())
        Dim PI As Double = 3.14
        Dim Area As Double
        Dim radius As Integer
        Console.WriteLine("Enter Radius of Circle:")
        radius = Console.ReadLine()
        Area = (PI * radius * radius)
        Console.WriteLine("Area of Circle={0}", Area)
    End Sub
End Module
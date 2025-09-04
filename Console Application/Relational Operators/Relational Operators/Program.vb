'Relational Operators (=,<>,<,>,<=,>=)
Imports System
Module Program
    Sub Main(args As String())
        Console.WriteLine("10=10     :{0}", (10 = 10))
        Console.WriteLine("10=20     :{0}", (10 = 20))
        Console.WriteLine("10<>20    :{0}", (10 <> 20))
        Console.WriteLine("10<>10    :{0}", (10 <> 10))
        Console.WriteLine("10<20     :{0}", (10 < 20))
        Console.WriteLine("100<20    :{0}", (100 < 20))
        Console.WriteLine("100>20    :{0}", (100 > 20))
        Console.WriteLine("100>200   :{0}", (100 > 200))
        Console.WriteLine("100>=20   :{0}", (100 >= 20))
        Console.WriteLine("100>=100  :{0}", (100 >= 100))
        Console.WriteLine("100<=100  :{0}", (100 <= 100))
        Console.WriteLine("100<=50   :{0}", (100 <= 50))
    End Sub
End Module
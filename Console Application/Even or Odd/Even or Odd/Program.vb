Module Program
	Sub Main()
		Dim no As Integer
		Console.WriteLine("Enter any number:")
		no = Console.ReadLine()
		If no Mod 2 = 0 Then
			Console.WriteLine("Number is EVEN")
		Else
			Console.WriteLine("Number is ODD")
		End If
	End Sub
End Module
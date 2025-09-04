Module Program
	Sub Main()
		Dim age As Integer
		Console.WriteLine("Enter any number:")
		age = Console.ReadLine()
		If age >= 18 Then
			Console.WriteLine("You are eligible for voting")
		Else
			Console.WriteLine("You are not eligible for voting")
		End If
	End Sub
End Module
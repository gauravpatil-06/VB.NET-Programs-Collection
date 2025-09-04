Module Program
	Sub Main()
		Dim no As Integer
		Console.WriteLine("Enter any number:")
		no = Console.ReadLine()
		If no <> 0 Then
			If no > 0 Then
				Console.WriteLine("Number is Positive")
			Else
				Console.WriteLine("Number is Negative")
			End If
		Else
			Console.WriteLine("0 is neither Positive nor negative")
		End If
	End Sub
End Module
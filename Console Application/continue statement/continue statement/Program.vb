Module Program
    Sub Main()
        Dim i As Integer
        i = 1
        Do While i <= 5
            If i = 3 Then
                i = i + 1
                Continue Do
            End If
            Console.WriteLine(i)
            i = i + 1
        Loop
    End Sub
End Module

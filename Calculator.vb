Module Module1

    Dim choice As String
    Dim num1, num2, ans As Integer


    Sub addition(ByVal x As Integer, ByVal y As Integer)
        ans = x + y
        Console.WriteLine(ans)
    End Sub
    Sub subtraction(ByVal x As Integer, ByVal y As Integer)
        ans = x - y
        Console.WriteLine(ans)
    End Sub
    Sub multi(ByVal x As Integer, ByVal y As Integer)
        ans = x * y
        Console.WriteLine(ans)
    End Sub
    Sub divi(ByVal x As Integer, ByVal y As Integer)
        ans = x / y
        Console.WriteLine(ans)
    End Sub


    Sub Main()

        Console.WriteLine("ENTER CHOICE")
        Console.WriteLine("1. Addition")
        Console.WriteLine("2. Subtraction")
        Console.WriteLine("3. Multiplication")
        Console.WriteLine("4. Division")
        choice = Console.ReadLine
        Console.WriteLine("Enter two numbers")
        num1 = Console.ReadLine
        num2 = Console.ReadLine

        If choice = 1 Then
            addition(num1, num2)
        ElseIf choice = 2 Then
            subtraction(num1, num2)
        ElseIf choice = 3 Then
            multi(num1, num2)
        ElseIf choice = 4 Then
            divi(num1, num2)
        End If

        Console.ReadKey()


    End Sub

End Module

Module Module1

    Sub Main()
        Dim str1, str2 As String
        Dim is_palindrome As Boolean

        str1 = ""
        str2 = ""
        is_palindrome = False

        Console.Write("Enter The String Check: ")
        str1 = Console.ReadLine
        str1 = str1.Replace(" ", "")
        str1 = UCase(str1)
        str2 = StrReverse(str1)

        If str2 = str1 Then
            is_palindrome = True
        Else
            is_palindrome = False

        End If
        If is_palindrome = True Then
            Console.Write("The written String is a palindrome")
        Else
            Console.Write("The written String is not a palindrome")
        End If
        Console.ReadKey()

    End Sub



End Module

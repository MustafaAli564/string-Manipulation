Module Module1

    Sub Main()
        Dim alpha, str1 As String
        Dim counter As Integer
        Dim is_pangram As Boolean

        alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        str1 = ""
        counter = 0
        is_pangram = False

        Console.Write("Enter String To Check: ")
        str1 = Console.ReadLine
        str1 = UCase(str1)

        If Len(str1) < 26 Then
            is_pangram = False
        Else
            For counter = 1 To 26
                If InStr(str1, Mid(alpha, counter, 1)) > 0 Then
                    is_pangram = True
                Else
                    is_pangram = False
                End If
            Next
        End If
        If is_pangram = True Then
            Console.Write("string is a pangram")
        Else
            Console.Write("string is not a pangram")
        End If
        Console.ReadKey()
    End Sub

End Module

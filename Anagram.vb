Module Module1

    Sub Main()
        Dim str1, str2 As String
        Dim counter As Integer
        Dim is_anagram As Boolean

        str1 = ""
        str2 = ""
        counter = 0
        is_anagram = False

        Console.Write("Enter First String: ")
        str1 = Console.ReadLine
        str1 = UCase(str1)

        Console.Write("Enter The Second Rearranged String: ")
        str2 = Console.ReadLine
        str2 = UCase(str2)

        If Len(str1) <> Len(str2) Then
            is_anagram = False
        Else
            For counter = 1 To Len(str1)
                If InStr(str2, Mid(str1, counter, 1)) > 0 Then
                    is_anagram = True
                Else
                    is_anagram = False
                    Exit For
                End If
            Next
        End If
        If is_anagram = True Then
            Console.Write("The two strings are anagrams")
        Else
            Console.Write("The two strings are not anagrams")
        End If
        Console.ReadKey()
    End Sub

End Module

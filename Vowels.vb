Module Module1

    Sub Main()
        Dim nextchar, str1, vow As String
        Dim counter, no_of_vow, x As Integer

        str1 = ""
        nextchar = ""
        counter = 0
        no_of_vow = 0
        vow = "AEIOUaeiou"
        x = 0

        Console.Write("Enter String To Check: ")
        str1 = Console.ReadLine

        For counter = 1 To Len(str1)
            nextchar = Mid(str1, counter, 1)
            x = InStr(vow, nextchar)
            If x > 0 Then
                no_of_vow = no_of_vow + 1
            End If
        Next
        Console.Write("Number Of vowels in this string is: " & no_of_vow)
        Console.ReadKey()
    End Sub

End Module

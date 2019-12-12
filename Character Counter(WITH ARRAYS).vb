Module Module1

    Sub Main()
        Dim myarr(26), i, x, y As Integer
        Dim str1 As String
        Dim nextchar, C As Char
        Dim valid As Boolean

        i = 0
        str1 = ""
        nextchar = ""
        x = 0
        C = ""
        valid = False

        For i = 1 To 26
            myarr(i) = 0
        Next

        Console.Write("Enter a phrase: ")
        str1 = Console.ReadLine
        str1 = LCase(str1)
        str1 = Replace(str1, " ", "")

        For i = 1 To Len(str1)
            nextchar = Mid(str1, i, 1)
            x = Asc(nextchar) - 96
            myarr(x) = myarr(x) + 1
        Next


        For i = 1 To 26
            If myarr(i) > 1 Then
                valid = True
                Exit For
            End If
        Next
        If valid = True Then
            Console.WriteLine("-->THE REPEATED CHARACTERS ARE<--")
            For i = 1 To 26
                If myarr(i) > 1 Then
                    x = i + 96
                    C = Chr(x)
                    C = UCase(C)
                    Console.WriteLine("            " & C & " = " & myarr(i))
                End If
            Next

        End If
        If valid = False Then
            Console.Write("No repeated characters found")
        End If

        Console.ReadKey()

    End Sub

End Module

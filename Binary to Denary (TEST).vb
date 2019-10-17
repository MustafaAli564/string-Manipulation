Module Module1

    Sub Main()
        Dim str1, str2, check, nextchar As String
        Dim counterer, val, X As Integer
        Dim ValidBinaryNumber As Boolean

        str1 = ""
        check = "23456789"
        counterer = 0
        ValidBinaryNumber = True
        val = 0
        str2 = ""
        nextchar = ""
        X = 0

        Console.Write("Enter Binary Number: ")
        str1 = Console.ReadLine

        If Len(str1) < 1 Or Len(str1) > 8 Then
            ValidBinaryNumber = False
        Else
            For counterer = 1 To Len(check)
                If InStr(str1, Mid(check, counterer, 1)) > 0 Then
                    ValidBinaryNumber = False
                End If
            Next
        End If
        If ValidBinaryNumber = False Then
            Console.Write("Entered Binary Number is not valid")

        End If
        If ValidBinaryNumber = True Then
            str2 = StrReverse(str1)

            For counter = 1 To Len(str2)
                nextchar = Mid(str2, counter, 1)

                If counter = 1 Then
                    If nextchar = "1" Then
                        val = val + 1
                    End If
                End If

                If counter = 2 Then
                    If nextchar = "1" Then
                        val = val + 2
                    End If
                End If

                If counter = 3 Then
                    If nextchar = "1" Then
                        val = val + 4
                    End If
                End If

                If counter = 4 Then
                    If nextchar = "1" Then
                        val = val + 8
                    End If
                End If

                If counter = 5 Then
                    If nextchar = "1" Then
                        val = val + 16
                    End If
                End If

                If counter = 6 Then
                    If nextchar = "1" Then
                        val = val + 32
                    End If
                End If

                If counter = 7 Then
                    If nextchar = "1" Then
                        val = val + 64
                    End If
                End If

                If counter = 8 Then
                    If nextchar = "1" Then
                        val = val + 128
                    End If
                End If

            Next
            Console.Write(str1 & " = " & val)
        End If
        Console.ReadKey()
    End Sub

End Module

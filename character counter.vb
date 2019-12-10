
Module Module1

    Sub Main()
        Dim str1, alpha, w1 As String
        Dim count, count2, rep, n1, n2, n3, n4, n5, n6, n7, n8, n9, n10, n11 As Integer
        Dim valid As Boolean
        Dim nextchar1, nextchar2 As Char


        alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        str1 = ""
        count = 0
        count2 = 0
        valid = True
        nextchar1 = ""
        nextchar2 = ""
        rep = 0
        w1 = ""


        Console.Write("Enter String Of One Word of at most eleven characters: ")
        str1 = Console.ReadLine

        If Len(str1) < 1 Then
            valid = False
        End If
        If valid = False Then
            Console.Write("Enter A VALID String dumbass")
        End If

        '------------------------------------------------------------

        If valid = True Then
            str1 = UCase(str1)
            For count = 1 To Len(str1)
                nextchar1 = Mid(str1, count, 1)

                For count2 = 1 To Len(str1)
                    nextchar2 = Mid(str1, count2, 1)

                    If nextchar1 = nextchar2 Then
                        rep = rep + 1
                    End If

                Next
                If count = 1 Then
                    n1 = rep
                    Console.WriteLine(nextchar1 & " " & ": " & n1)
                End If
                If count = 2 Then
                    n2 = rep
                    Console.WriteLine(nextchar1 & " " & ": " & n2)
                End If
                If count = 3 Then
                    n3 = rep
                    Console.WriteLine(nextchar1 & " " & ": " & n3)
                End If
                If count = 4 Then
                    n4 = rep
                    Console.WriteLine(nextchar1 & " " & ": " & n4)
                End If
                If count = 5 Then
                    n5 = rep
                    Console.WriteLine(nextchar1 & " " & ": " & n5)
                End If
                If count = 6 Then
                    n6 = rep
                    Console.WriteLine(nextchar1 & " " & ": " & n6)
                End If
                If count = 7 Then
                    n7 = rep
                    Console.WriteLine(nextchar1 & " " & ": " & n7)
                End If
                If count = 8 Then
                    n8 = rep
                    Console.WriteLine(nextchar1 & " " & ": " & n8)
                End If
                If count = 9 Then
                    n9 = rep
                    Console.WriteLine(nextchar1 & " " & ": " & n9)
                End If
                If count = 10 Then
                    n10 = rep
                    Console.WriteLine(nextchar1 & " " & ": " & n10)
                End If
                If count = 11 Then
                    n11 = rep
                    Console.WriteLine(nextchar1 & " " & ": " & n11)
                End If

                rep = 0

            Next

        End If
        Console.ReadKey()




    End Sub


End Module

Module Module1

    Sub Main()
        Dim str1 As String
        Dim count As Integer
        Dim nextchar As String
        Dim hchar As String
        Dim valid As Boolean
        Dim rep As Integer
        Dim count2 As Integer
        Dim hcount As Integer
        Dim char1 As String
        Dim char2 As String


        str1 = ""
        count = 0
        nextchar = ""
        hchar = ""
        valid = True
        rep = 0
        count2 = 0
        hcount = 0



        Console.Write("Enter String: ")
        str1 = Console.ReadLine

        If Len(str1) < 1 Then
            valid = False
        Else
            If str1 = "" Then
                valid = False
            End If
        End If
        If valid = False Then
            Console.Write("The Entered String Is Not Valid")
        End If

        If valid = True Then
            str1 = str1.Replace(" ", "")
            str1 = UCase(str1)
            For count = 1 To Len(str1)
                char1 = Mid(str1, count, 1)
                For count2 = count To Len(str1)
                    char2 = Mid(str1, count2, 1)
                    If String.Equals(char1, char2) Then
                        rep = rep + 1
                    End If
                Next
                If rep > hcount Then
                    hcount = rep
                    hchar = char1
                End If
                rep = 0
            Next
            If hcount = 1 Then
                Console.WriteLine("No repetation")
            Else
                Console.WriteLine("Most Repeated character is: " & hchar)
            End If
        End If


        Console.ReadKey()



    End Sub

End Module

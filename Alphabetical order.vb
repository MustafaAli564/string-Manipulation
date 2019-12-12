Module Module1

    Sub Main()
        Dim myarr(500), x, y, bub As String
        Dim i, j, no As Integer
        Dim nextchar As Char


        i = 0
        nextchar = ""
        x = ""
        y = ""
        j = 0
        bub = ""
        no = 0

        Console.Write("How many Names/Words would you like to arrange?: ")
        no = Console.ReadLine

        For i = 1 To no
            myarr(i) = ""
        Next

        For i = 1 To no
            Console.Write("Enter a name or word: ")
            x = Console.ReadLine
            y = UCase(x)
            myarr(i) = y
        Next
        For i = no - 1 To 1 Step -1
            For j = 1 To i
                If myarr(j) > myarr(j + 1) Then
                    bub = myarr(j)
                    myarr(j) = myarr(j + 1)
                    myarr(j + 1) = bub
                End If
            Next
        Next

        For i = 1 To no
            Console.WriteLine(myarr(i))
        Next


        Console.ReadKey()
    End Sub

End Module

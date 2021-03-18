Module Module1
    Dim sort(3) As String
    Sub Main()
        Dim count As Integer
        Dim val As String
        Dim ans As String

        For count = 0 To 3
            Console.Write("Enter String to sort: ")
            val = Console.ReadLine
            sort(count) = val
        Next
        Console.WriteLine("Ascending Order (1)")
        Console.WriteLine("Descending Order (2)")
        ans = Console.ReadLine
        Console.Clear()
        Select Case ans
            Case "1" : Call Asc()
            Case "2" : Call Desc()
        End Select

        For count = 0 To 3
            Console.WriteLine(sort(count))
        Next
        Console.ReadKey()
    End Sub
    Sub Asc()
        Dim x As Integer
        Dim dynamic As String


        For x = 1 To 3
            dynamic = sort(x)

            While dynamic < sort(x - 1)
                sort(x) = sort(x - 1)
                sort(x - 1) = dynamic
                x = x - 1
                If x = 0 Then
                    Exit While
                End If
            End While
        Next


    End Sub




    Sub Desc()
        Dim x As Integer
        Dim dynamic As String


        For x = 1 To 3
            dynamic = sort(x)

            While dynamic > sort(x - 1)
                sort(x) = sort(x - 1)
                sort(x - 1) = dynamic
                x = x - 1
                If x = 0 Then
                    Exit While
                End If
            End While
        Next
    End Sub

End Module

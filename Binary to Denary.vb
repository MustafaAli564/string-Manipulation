Module Module1

    Sub Main()
        Dim bin As String
        Dim counter, n, den, x As Integer
        Dim val As Boolean


        counter = 0
        n = 0
        val = False

        Do Until val = True

            Console.Write("Enter a binary number: ")
            bin = Console.ReadLine


            For x = 1 To Len(bin)
                If Mid(bin, x, 1) = "0" Or Mid(bin, x, 1) = "1" Then
                    val = True
                Else
                    val = False
                    Exit For
                End If
            Next
            If val = False Then
                Console.WriteLine("!!! Invalid Input !!!")
                Console.ReadKey()
                Console.Clear()
            End If
        Loop

        If val = True Then
            For counter = Len(bin) To 1 Step -1
                If Mid(bin, counter, 1) Then
                    den = den + 2 ^ n
                End If
                n = n + 1

            Next
            Console.WriteLine("denary= " & den)
            Console.ReadKey()
        End If

    End Sub

End Module

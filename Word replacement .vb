Module Module1

    Sub Main()

        Dim str1, str2, str3, str4, firstword, middword, lastword As String
        Dim Sp As Integer

        str1 = ""
        str2 = ""
        str3 = ""
        str4 = ""
        firstword = ""
        Middword = ""
        lastword = ""
        Sp = 0

        Console.Write("Enter first string of two words: ")
        str1 = Console.ReadLine

        Console.Write("Enter second string of two words: ")
        str2 = Console.ReadLine

        Console.Write("Enter third string of two words: ")
        str3 = Console.ReadLine

        Sp = InStr(str1, " ")
        firstword = Left(str1, Sp - 1)

        Sp = InStr(str2, " ")
        middword = Right(str2, Len(str2) - Sp)

        Sp = InStr(str3, " ")
        lastword = Right(str3, Len(str3) - Sp)

        str4 = firstword & " " & middword & " " & lastword
        Console.WriteLine(str4)

        Console.ReadKey()
    End Sub

End Module

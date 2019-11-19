Module Module1

    Sub Main()
        Dim string1 As String
        Dim string2 As String
        Dim string3 As String
        Dim firstWord As String
        Dim secondWord As String
        Dim Sp As Integer

        string1 = ""
        string2 = ""
        string3 = ""
        firstWord = ""
        secondWord = ""
        Sp = 0

        Console.WriteLine("Enter string1")
        string1 = Console.ReadLine

        Console.WriteLine("Enter string2")
        string2 = Console.ReadLine

        Sp = InStr(string1, " ")
        firstWord = Mid(string1, 1, Sp)
        Sp = InStr(string2, " ")
        secondWord = Right(string2, Len(string2) - Sp)
        string3 = firstWord & secondWord

        Console.Write(string3)
        Console.ReadKey()





    End Sub

End Module

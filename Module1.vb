Module Module1

    Sub Main()
        Dim String1 As String
        Dim String2 As String
        Dim Char1 As Char
        Dim Char2 As Char
        Dim nextchar As Char
        Dim Counter As Integer

        String1 = ""
        String2 = ""
        Char1 = ""
        Char2 = ""
        nextchar = ""
        Counter = 0

        Console.Write("Enter String1 : ")
        String1 = Console.ReadLine

        Console.Write("Enter character to remove: ")
        Char1 = Console.ReadLine

        Console.Write("Enter character to replce: ")
        Char2 = Console.ReadLine

        For Counter = 1 To Len(String1)
            nextchar = Mid(String1, Counter, 1)
            If nextchar = Char1 Then
                nextchar = Char2
            End If
            String2 = String2 & nextchar
        Next

        Console.WriteLine("Final string = " & String2)
        Console.ReadKey()



    End Sub

End Module
Module Module1

    Sub Main()
        Dim string1 As String
        Dim string2 As String
        Dim CharRemove1 As Char
        Dim CharRemove2 As Char
        Dim CharRemove3 As Char
        Dim Counter As Integer
        Dim X As String

        string1 = ""
        string2 = ""
        CharRemove1 = ""
        CharRemove2 = ""
        CharRemove3 = ""
        Counter = 0

        Console.WriteLine("enter string1")
        string1 = Console.ReadLine

        Console.WriteLine("enter character to remove")
        CharRemove1 = Console.ReadLine
        Console.WriteLine("enter character to remove")
        CharRemove2 = Console.ReadLine
        Console.WriteLine("enter character to remove")
        CharRemove3 = Console.ReadLine

        For Counter = 1 To Len(string1)
            X = Mid(string1, Counter, 1)
            If X <> CharRemove1 And X <> CharRemove2 And X <> CharRemove3 Then
                string2 = string2 & X
            End If
        Next
        Console.WriteLine("Final string = " & string2)
        Console.ReadKey()

    End Sub

End Module

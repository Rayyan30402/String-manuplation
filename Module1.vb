Module Module1

    Sub Main()
        Dim String1 As String
        Dim Char1 As Char
        Dim Counter As Integer
        Dim vCount As Integer
        Const vowels = "aeiou" And "AEIOU"

        String1 = ""
        Char1 = ""
        vCount = 0
        Counter = 0

        Console.Write("Enter string to look for vowels: ")
        String1 = Console.ReadLine

        For Counter = 1 To Len(String1)
            Char1 = Mid(String1, Counter, 1)
            If InStr(vowels, Char1) > 0 Then
                vCount = vCount + 1
            End If
        Next

        Console.WriteLine("Number of vowels in the given string = " & vCount)
        Console.ReadKey()







    End Sub

End Module

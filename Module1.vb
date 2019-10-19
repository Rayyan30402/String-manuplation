Module Module1

    Sub Main()
        Dim String1 As String
        Dim String2 As String
        Dim String3 As String
        Dim nextchar1 As String
        Dim nextchar2 As String
        Dim counter1 As Integer
        Dim counter2 As Integer
        Dim haschanged As Boolean

        String1 = ""
        String2 = ""
        String3 = ""
        nextchar1 = ""
        nextchar2 = ""
        counter1 = 0
        counter2 = 0
        haschanged = True / False

        For counter1 = 1 To Len(String1)
            nextchar1 = Mid(String1, counter1, 1)
            String3 = ""
            haschanged = False
               counter2 = 1 To Len(String2)
            nextchar2 = Mid(String2, counter2, 1)
            If nextchar2 = nextchar1 Then

                haschanged = False
            Else
                haschanged = True
                    console.write("String3="'String3 & nextxhar1')
            End If



        Next
        String2 = String3
        Console.ReadKey()
    End Sub

End Module

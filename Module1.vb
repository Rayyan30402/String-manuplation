Module Module1

    Sub Main()
        Dim validBinary As Boolean
        Dim Binarynumbers As Integer
        Dim Counter1 As Integer
        Dim nextnum As Integer

        validBinary = True / False
        Binarynumbers = 0
        Counter1 = 0
        nextnum = 0

        Console.WriteLine("enter Binarynumbers")
        Binarynumbers = Console.ReadLine

        For Counter1 = 1 To 8
              Mid(Binarynumbers, Counter1, 1)
            If Binarynumbers = 0 And 1 Then
                Console.WriteLine("it is a valid Binary string")
            End If
            validBinary = True
         ElseIf 
            nextnum = Binarynumbers

            validBinary = True
            Else
            validBinary = False

        Next

    End Sub
End Module

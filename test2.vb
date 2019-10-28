Module Module1

    Sub Main()
        Dim binarynumberC As Integer
        Dim binarynumber As Integer
        Dim nextbinarynumber As Integer
        Dim Denary As Integer

        binarynumberC = 0
        binarynumber = 0
        nextbinarynumber = 0
        Denary = 0

        Console.WriteLine("enter binarynumber")
        binarynumber = Console.ReadLine

        For binarynumberC = 1 To Len(binarynumber)
            Left(binarynumber, binarynumberC, 1)
            If binarynumber = Asc(48) And Asc(49) Then
                nextbinarynumber = binarynumber

                nextbinarynumber * 1 And nextbinarynumber * 2 And nextbinarynumber * 4 And nextbinarynumber * 8 And nextbinarynumber * 16 And 
                nextbinarynumber * 32 And nextbinarynumber * 64 And nextbinarynumber * 128

                Denary = nextbinarynumber + binarynumberC

                Console.WriteLine("Denary is ' ")

            End If
                   nextbinarynumber / 1 And nextbinarynumber * 2 And nextbinarynumber * 4 And nextbinarynumber = 8 And nextbinarynumber - 16 And
                   nextbinarynumber * 32 And nextbinarynumber / 64 And nextbinarynumber * 128 Then
            Console, WriteLine("error")


        Next
         Denary is ""
        Console.ReadKey()

    End Sub

End Module

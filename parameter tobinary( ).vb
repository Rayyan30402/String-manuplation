Module Module1

    Sub Main()
        Dim num1 As Integer
        Dim x As Integer
        Dim leftrem As Integer
        Dim binary As String
        Dim ln As Integer
        Dim finalbinary As String


        num1 = 0
        x = 0
        leftrem = 0
        binary = ""
        ln = 0
        finalbinary = ""


        console.writeline("enter num1")
        num1 = console.readline



            While (num1 > 0)

                x = num1 Mod 2
                If x = 1 Then
                    leftrem = num1 Mod 2
                    num1 = num1 - 1
                    num1 = num1 / 2
                    binary = binary & leftrem
                ElseIf x = 0 Then
                    leftrem = num1 Mod 2
                    num1 = num1 / 2
                    binary = binary & leftrem
                End If
            End While
            ln = Len(binary)
            While (ln > 0)
                finalbinary = finalbinary & Mid(binary, ln, 1)
                ln = ln - 1
            End While
            Console.WriteLine(finalbinary)


            Console.ReadKey()

    End Sub

    Private Function AscValue(ByVal p1 As Object) As Integer
        Throw New NotImplementedException
    End Function

End Module

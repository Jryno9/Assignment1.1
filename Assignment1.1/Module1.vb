Module Module1

    Sub Main()
        Dim inpstr, str1 As String
        Dim count As Integer
        Dim cmpchar As Char
        Dim Notfound As Boolean

        inpstr = ""
        str1 = "abcdefghijklmnopqrstuvwxyz"
        count = 0
        Notfound = False

        Console.Write("Enter the string : ")
        inpstr = Console.ReadLine()
        For count = 1 To Len(inpstr)
            cmpchar = Mid(inpstr, count, 1)
            If InStr(str1, LCase(cmpchar)) = 0 Then
                Notfound = True
                Exit For
            Else
                Notfound = False
            End If

        Next
        If Notfound = True Then
            Console.WriteLine("Does not contain all alphabets ")
        Else
            Console.WriteLine("Does contain all alphabets")
        End If




        Console.ReadKey()
    End Sub

End Module

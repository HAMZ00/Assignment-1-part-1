Module Module1

    Sub Main()
        Dim MemberID As Integer = 0
        Dim Name As String = " "

        FileOpen(1, "E:\hamza\vb\assignment1.txt", OpenMode.Input)

        While Not EOF(1)
            Input(1, Name)
            Input(1, MemberID)
            Console.WriteLine(Name)
            Console.WriteLine(MemberID)
            Console.WriteLine(" ")
        End While
        Console.ReadKey()

    End Sub

End Module

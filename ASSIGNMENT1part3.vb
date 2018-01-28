Module Module1

    Sub Main()
        Dim MemberID As Integer = 0
        Dim Name As String = " "
        Dim FindName As String = " "
        Dim FindID As Integer = " "
        Dim found As Boolean = False

        FileOpen(1, "E:\hamza\vb\assignment1.txt", OpenMode.Input)

        Console.WriteLine("Enter name to be searched: ")
        FindName = FindName.ToLower()

        Do
            Input(1, Name)
            Input(1, MemberID)

            Name = Name.ToLower

            If FindName = Name Then
                found = True
                Console.WriteLine("member name: ")
                Console.WriteLine(MemberID)
                Console.Write("member id : ")
                Console.WriteLine(FindID)
            Else
                found = False
            End If
        Loop Until Not EOF(1) Or found = True

        If found = False Then
            Console.WriteLine(" RECORD NOT FOUND")

        End If
        Console.ReadKey()

    End Sub

End Module

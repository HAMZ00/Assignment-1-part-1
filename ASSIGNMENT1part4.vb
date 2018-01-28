Module Module1

    Sub Main()
        Dim MemberID As Integer = 0
        Dim Name As String = " "
        Dim MoreMembers As Boolean = False

        FileOpen(1, "E:\hamza\vb\assignment1.txt", OpenMode.Append)

        Console.WriteLine("Do you want to add more members (True/False)?")
        MoreMembers = Console.ReadLine
        While MoreMembers = True
            Console.WriteLine("Enter Name: ")
            Name = Console.ReadLine
            Console.WriteLine("enter MemberID:")
            MemberID = Console.ReadLine

            WriteLine(1, Name)
            WriteLine(1, MemberID)

            Console.WriteLine("do you want to add more members (True/False)?")
            MoreMembers = Console.ReadLine
        End While
        Console.ReadKey()

    End Sub

End Module

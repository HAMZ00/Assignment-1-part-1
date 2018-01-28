Module Module1

    Sub Main()
        Dim MemberID As Integer = 0
        Dim Name As String = " "
        Dim Finish As Integer = 0

        FileOpen(1, "E:\hamza\vb\assignment1.txt", OpenMode.Append)
        Do
            Console.WriteLine("enter name: ")
            Name = Console.ReadLine
            Console.WriteLine("enter membership ID: ")
            MemberID = Console.ReadLine

            WriteLine(1, Name)
            WriteLine(1, MemberID)
            Console.WriteLine(" ")
            Console.WriteLine("Press 1 if you dont want to add more data.")
            Finish = Console.ReadLine()

        Loop Until Finish = 1
    End Sub

End Module

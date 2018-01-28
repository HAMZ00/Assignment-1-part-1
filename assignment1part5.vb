Module Module1

    Sub Main()
        Dim MemberID As Integer = 0
        Dim Name As String = " "
        Dim TelNum As String = " "
        Dim MembershipDate As Date

        FileOpen(1, "E:\hamza\vb\assignment1.txt", OpenMode.Input)
        FileOpen(2, "E:\hamza\vb\assignment1-1.txt", OpenMode.Append)

        While Not EOF(1)
            Input(1, Name)
            Console.WriteLine(Name)
            Input(1, MemberID)
            Console.WriteLine(MemberID)
            Console.WriteLine("enter telephone number :")
            TelNum = Console.ReadLine
            Console.WriteLine("enter membership date :")
            MembershipDate = Console.ReadLine

            WriteLine(2, Name)
            WriteLine(2, MemberID)
            WriteLine(2, TelNum)
            WriteLine(2, MembershipDate)

        End While
        
        Console.ReadKey()

    End Sub

End Module

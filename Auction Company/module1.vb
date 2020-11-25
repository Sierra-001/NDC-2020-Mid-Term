Module module1
    Sub Main()
        Dim ReservePrice(9), NumBits(9), HighestBits(9) As Integer
        Dim Item(9), Description(9) As String

        For index = 0 To 9
            Console.WriteLine("Enter Item " & index + 1 & " Name :")
            Item(index) = Console.ReadLine
            Console.WriteLine("Enter " & Item(index) & " Description")
            Description(index) = Console.ReadLine
            Console.WriteLine("Enter Reserved Price For " & Item(index) & " :")
            ReservePrice(index) = Console.ReadLine
            NumBits(index) = 0
            Console.Clear()
        Next

        For index = 0 To 9
            Console.WriteLine("Item " & index + 1 & ": " & Item(index))
            Console.WriteLine(Item(index) & " Description :" & Description(index))
            Console.WriteLine(Item(index) & " Reserve Price : " & ReservePrice(index))
            Console.WriteLine("Current Bits: " & NumBits(index))
            Console.WriteLine()
            'If (index = 9) Then
            '    Console.WriteLine("press enter to exit!")
            'End If
        Next

        Console.ReadKey()
    End Sub
End Module
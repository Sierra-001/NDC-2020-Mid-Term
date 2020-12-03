Module Module1

    Sub Main()
        Dim limit As Integer = 9    'Task 1
        Dim Item(limit), ReservePrice(limit) As Integer
        Dim Description(limit) As String

        For count = 0 To limit
            Item(count) = (count + 1)
            Console.WriteLine("Item " & Item(count))
            Console.WriteLine("Please Enter Description for Item " & Item(count))
            Description(count) = Console.ReadLine
            Console.WriteLine("Please Enter the Reserve Price for Item " & Item(count))
            ReservePrice(count) = Console.ReadLine
            Console.Clear()
        Next

        Console.ReadKey()
    End Sub

End Module
